using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace FileReceiver
{
    public partial class MainForm : Form
    {
        const int PORT = 1723;

        public MainForm()
        {
            InitializeComponent();
        }

        private void resetControls()
        {
            progressBar1.Style = ProgressBarStyle.Marquee;
            textBox1.Text = "Waiting for connection...";
        }

        protected override async void OnShown(EventArgs e)
        {
            // Listen
            TcpListener listener = TcpListener.Create(PORT);
            listener.Start();
            textBox1.Text = "Waiting for connection...";
            TcpClient client = await listener.AcceptTcpClientAsync();
            NetworkStream ns = client.GetStream();

            // Get file info
            long fileLength;
            string fileName;
            {
                byte[] fileNameBytes;
                byte[] fileNameLengthBytes = new byte[4]; //int32
                byte[] fileLengthBytes = new byte[8]; //int64

                await ns.ReadAsync(fileLengthBytes, 0, 8); // int64
                await ns.ReadAsync(fileNameLengthBytes, 0, 4); // int32
                fileNameBytes = new byte[BitConverter.ToInt32(fileNameLengthBytes, 0)];
                await ns.ReadAsync(fileNameBytes, 0, fileNameBytes.Length);

                fileLength = BitConverter.ToInt64(fileLengthBytes, 0);
                fileName = ASCIIEncoding.ASCII.GetString(fileNameBytes);
            }

            // Get permission
            if (MessageBox.Show(String.Format("Requesting permission to receive file:\r\n\r\n{0}\r\n{1} bytes long", fileName, fileLength), "", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            // Set save location
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CreatePrompt = false;
            sfd.OverwritePrompt = true;
            sfd.FileName = fileName;
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                ns.WriteByte(0); // Permission denied
                return;
            }
            ns.WriteByte(1); // Permission grantedd
            FileStream fileStream = File.Open(sfd.FileName, FileMode.Create);

            // Receive
            textBox1.Text = "Receiving...";
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Value = 0;
            int read;
            int totalRead = 0;
            byte[] buffer = new byte[32 * 1024]; // 32k chunks
            while ((read = await ns.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await fileStream.WriteAsync(buffer, 0, read);
                totalRead += read;
                progressBar1.Value = (int)((100d * totalRead) / fileLength);
            }

            fileStream.Dispose();
            client.Close();
            MessageBox.Show("File successfully received");
            resetControls();
        }
    }
}
