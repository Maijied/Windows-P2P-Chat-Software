﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace FileSender
{
    public partial class MainForm : Form
    {
        const int PORT = 1723;

        public MainForm()
        {
            InitializeComponent();
            textBox2.Click += textBox2_Click;
        }

        void resetControls()
        {
            textBox1.Enabled = textBox2.Enabled = button1.Enabled = true;
            button1.Text = "Send";
            progressBar1.Value = 0;
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        void textBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = textBox2.Enabled = button1.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;

            // Parsing
            button1.Text = "Preparing...";
            IPAddress address;
            FileInfo file;
            FileStream fileStream;
            if (!IPAddress.TryParse(textBox1.Text, out address))
            {
                MessageBox.Show("Error with IP Address");
                resetControls();
                return;
            }
            try
            {
                file = new FileInfo(textBox2.Text);
                fileStream = file.OpenRead();
            }
            catch
            {
                MessageBox.Show("Error opening file");
                resetControls();
                return;
            }

            // Connecting
            button1.Text = "Connecting...";
            TcpClient client = new TcpClient();
            try
            {
                await client.ConnectAsync(address, PORT);
            }
            catch
            {
                MessageBox.Show("Error connecting to destination");
                resetControls();
                return;
            }
            NetworkStream ns = client.GetStream();

            // Send file info
            button1.Text = "Sending file info...";
            { // This syntax sugar is awesome
                byte[] fileName = ASCIIEncoding.ASCII.GetBytes(file.Name);
                byte[] fileNameLength = BitConverter.GetBytes(fileName.Length);
                byte[] fileLength = BitConverter.GetBytes(file.Length);
                await ns.WriteAsync(fileLength, 0, fileLength.Length);
                await ns.WriteAsync(fileNameLength, 0, fileNameLength.Length);
                await ns.WriteAsync(fileName, 0, fileName.Length);
            }

            // Get permissions
            button1.Text = "Getting permission...";
            {
                byte[] permission = new byte[1];
                await ns.ReadAsync(permission, 0, 1);
                if (permission[0] != 1)
                {
                    MessageBox.Show("Permission denied");
                    resetControls();
                    return;
                }
            }

            // Sending
            button1.Text = "Sending...";
            progressBar1.Style = ProgressBarStyle.Continuous;
            int read;
            int totalWritten = 0;
            byte[] buffer = new byte[32 * 1024]; // 32k chunks
            while ((read = await fileStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await ns.WriteAsync(buffer, 0, read);
                totalWritten += read;
                progressBar1.Value = (int)((100d * totalWritten) / file.Length);
            }

            fileStream.Dispose();
            client.Close();
            MessageBox.Show("Sending complete!");
            resetControls();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
