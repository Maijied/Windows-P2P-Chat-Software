using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Collections;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace NanoChat
{

    
        public partial class Form1 : Form
        {
            
            
            Socket sck;
            EndPoint epLocal, epRemote;
            byte[] buffer;
            byte[] b1;
        OpenFileDialog op;
            string n;

        public Form1()
            {
                InitializeComponent();
                       
            }

            

            

            private void Form1_Load(object sender, EventArgs e)
            {

                //Set Up Socket
                sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

                //Get User Ip
                textLocalIp.Text = GetLocalIp();
                textRemoteIp.Text = GetLocalIp();

            }



            private string GetLocalIp()
            {
                IPHostEntry host;
                host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                        return ip.ToString();
                }
                return "127.0.0.1";
            //throw new Exception("No network adapters with an IPv4 address in the system!");

        }
            private void buttonConnect_Click(object sender, EventArgs e)
            {
            
                //Binding Socket

                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                //Connecting To Remote Ip
                epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
                sck.Connect(epRemote);

                //Listing the specific Port
                buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }


            private void MessageCallBack(IAsyncResult aResult)
            {
                try
                {
                    byte[] receivedData = new byte[1500];
                    receivedData = (byte[])aResult.AsyncState;

                    //Converting Byte to String
                    ASCIIEncoding aEncoding = new ASCIIEncoding();
                    string receivedMessage = aEncoding.GetString(receivedData);

                    //Adding The Message Into ListBox
                    listMessage.Items.Add("Friend: " + receivedMessage);

                    buffer = new byte[1500];
                    sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
            
                Application.Exit();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                WindowState = FormWindowState.Minimized;
            }

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void color_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
            

            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void colorblue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;


            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void colorpink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;


            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void colorgray_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Honeydew;


            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void colorsea_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;


            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void colorturquise_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkTurquoise;


            Graphics g = CreateGraphics();

            Pen brown = new Pen(Color.Brown);
            g.FillRectangle(brown.Brush, 201, 400, 100, 50);
        }

        private void schat_Click(object sender, EventArgs e)
        {
            if(listMessage.Items.Count>0)
            {
                using (TextWriter TW = new StreamWriter("list.txt"))
                {
                    foreach(string iteamText in listMessage.Items)
                    {
                        TW.WriteLine(iteamText);
                    }
                }
                Process.Start("list.txt");
            }
        }

       

        private void browseFile_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string t = textBox1.Text;
                t = op.FileName;
                FileInfo fi = new FileInfo(textBox1.Text = op.FileName);
                n = fi.Name + "." + fi.Length;
                TcpClient client = new TcpClient();
                StreamWriter sw = new StreamWriter(client.GetStream());
                sw.WriteLine(n);
                sw.Flush();
                label1.Text = "File Transferred....";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendFile_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            Stream s = client.GetStream();
            b1 = File.ReadAllBytes(op.FileName);
            s.Write(b1, 0, b1.Length);
            client.Close();
            label1.Text = "File Transferred....";
        }

        private void buttonSend_Click(object sender, EventArgs e)
            {
                //Convert string message to byte
                ASCIIEncoding aEncoding = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1500];
                sendingMessage = aEncoding.GetBytes(textMessage.Text);

                //sending the encoded Message
                sck.Send(sendingMessage);
                //Adding the listbox
                listMessage.Items.Add("Me: " + textMessage.Text);
                textMessage.Text = "";

            }

        }
    }

