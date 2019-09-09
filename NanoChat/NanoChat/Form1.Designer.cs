namespace NanoChat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textLocalIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textRemotePort = new System.Windows.Forms.TextBox();
            this.textRemoteIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.colorblue = new System.Windows.Forms.Button();
            this.colorpink = new System.Windows.Forms.Button();
            this.colorgray = new System.Windows.Forms.Button();
            this.colorsea = new System.Windows.Forms.Button();
            this.colorturquise = new System.Windows.Forms.Button();
            this.schat = new System.Windows.Forms.Button();
            this.browseFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.sendFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.receiveFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLocalPort);
            this.groupBox1.Controls.Add(this.textLocalIp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 102);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(331, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(83, 64);
            this.textLocalPort.Margin = new System.Windows.Forms.Padding(4);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(148, 24);
            this.textLocalPort.TabIndex = 1;
            // 
            // textLocalIp
            // 
            this.textLocalIp.Location = new System.Drawing.Point(83, 30);
            this.textLocalIp.Margin = new System.Windows.Forms.Padding(4);
            this.textLocalIp.Name = "textLocalIp";
            this.textLocalIp.Size = new System.Drawing.Size(148, 24);
            this.textLocalIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textRemotePort);
            this.groupBox2.Controls.Add(this.textRemoteIp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(511, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(335, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Friend";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Port :";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Location = new System.Drawing.Point(88, 58);
            this.textRemotePort.Margin = new System.Windows.Forms.Padding(4);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.Size = new System.Drawing.Size(148, 24);
            this.textRemotePort.TabIndex = 1;
            // 
            // textRemoteIp
            // 
            this.textRemoteIp.Location = new System.Drawing.Point(88, 24);
            this.textRemoteIp.Margin = new System.Windows.Forms.Padding(4);
            this.textRemoteIp.Name = "textRemoteIp";
            this.textRemoteIp.Size = new System.Drawing.Size(148, 24);
            this.textRemoteIp.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP :";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(893, 115);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(193, 85);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(65, 610);
            this.textMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(781, 24);
            this.textMessage.TabIndex = 3;
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 17;
            this.listMessage.Location = new System.Drawing.Point(65, 245);
            this.listMessage.Margin = new System.Windows.Forms.Padding(4);
            this.listMessage.Name = "listMessage";
            this.listMessage.ScrollAlwaysVisible = true;
            this.listMessage.Size = new System.Drawing.Size(781, 344);
            this.listMessage.TabIndex = 4;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(877, 606);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(112, 30);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Blackoak Std", 25.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(259, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(660, 47);
            this.label5.TabIndex = 6;
            this.label5.Text = "NaNo Chat App.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Std", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Developed By Maizied And  Bayeed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1064, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "---";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(974, 280);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(101, 42);
            this.color.TabIndex = 12;
            this.color.Text = "Red";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // colorblue
            // 
            this.colorblue.Location = new System.Drawing.Point(877, 280);
            this.colorblue.Name = "colorblue";
            this.colorblue.Size = new System.Drawing.Size(91, 42);
            this.colorblue.TabIndex = 13;
            this.colorblue.Text = "Blue";
            this.colorblue.UseVisualStyleBackColor = true;
            this.colorblue.Click += new System.EventHandler(this.colorblue_Click);
            // 
            // colorpink
            // 
            this.colorpink.Location = new System.Drawing.Point(877, 328);
            this.colorpink.Name = "colorpink";
            this.colorpink.Size = new System.Drawing.Size(91, 42);
            this.colorpink.TabIndex = 15;
            this.colorpink.Text = "Pink";
            this.colorpink.UseVisualStyleBackColor = true;
            this.colorpink.Click += new System.EventHandler(this.colorpink_Click);
            // 
            // colorgray
            // 
            this.colorgray.Location = new System.Drawing.Point(975, 328);
            this.colorgray.Name = "colorgray";
            this.colorgray.Size = new System.Drawing.Size(100, 42);
            this.colorgray.TabIndex = 16;
            this.colorgray.Text = "Gray";
            this.colorgray.UseVisualStyleBackColor = true;
            this.colorgray.Click += new System.EventHandler(this.colorgray_Click);
            // 
            // colorsea
            // 
            this.colorsea.Location = new System.Drawing.Point(877, 376);
            this.colorsea.Name = "colorsea";
            this.colorsea.Size = new System.Drawing.Size(91, 42);
            this.colorsea.TabIndex = 17;
            this.colorsea.Text = "Sea Green";
            this.colorsea.UseVisualStyleBackColor = true;
            this.colorsea.Click += new System.EventHandler(this.colorsea_Click);
            // 
            // colorturquise
            // 
            this.colorturquise.Location = new System.Drawing.Point(975, 376);
            this.colorturquise.Name = "colorturquise";
            this.colorturquise.Size = new System.Drawing.Size(100, 42);
            this.colorturquise.TabIndex = 18;
            this.colorturquise.Text = "Turquoise";
            this.colorturquise.UseVisualStyleBackColor = true;
            this.colorturquise.Click += new System.EventHandler(this.colorturquise_Click);
            // 
            // schat
            // 
            this.schat.Location = new System.Drawing.Point(996, 606);
            this.schat.Name = "schat";
            this.schat.Size = new System.Drawing.Size(111, 30);
            this.schat.TabIndex = 19;
            this.schat.Text = "save chat";
            this.schat.UseVisualStyleBackColor = true;
            this.schat.Click += new System.EventHandler(this.schat_Click);
            // 
            // browseFile
            // 
            this.browseFile.Location = new System.Drawing.Point(925, 508);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(108, 41);
            this.browseFile.TabIndex = 20;
            this.browseFile.Text = "Browse File";
            this.browseFile.UseVisualStyleBackColor = true;
            this.browseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(906, 443);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "--------SEND FILE--------";
            // 
            // sendFile
            // 
            this.sendFile.Location = new System.Drawing.Point(877, 555);
            this.sendFile.Name = "sendFile";
            this.sendFile.Size = new System.Drawing.Size(108, 34);
            this.sendFile.TabIndex = 22;
            this.sendFile.Text = "Send File";
            this.sendFile.UseVisualStyleBackColor = true;
            this.sendFile.Click += new System.EventHandler(this.sendFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(890, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "--------Change Color--------";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(877, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 24);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "                   File Path........";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // receiveFile
            // 
            this.receiveFile.Location = new System.Drawing.Point(992, 555);
            this.receiveFile.Name = "receiveFile";
            this.receiveFile.Size = new System.Drawing.Size(108, 34);
            this.receiveFile.TabIndex = 25;
            this.receiveFile.Text = "Receive File";
            this.receiveFile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1112, 674);
            this.Controls.Add(this.receiveFile);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sendFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.browseFile);
            this.Controls.Add(this.schat);
            this.Controls.Add(this.colorturquise);
            this.Controls.Add(this.colorsea);
            this.Controls.Add(this.colorgray);
            this.Controls.Add(this.colorpink);
            this.Controls.Add(this.colorblue);
            this.Controls.Add(this.color);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nano Chat App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textLocalIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textRemotePort;
        private System.Windows.Forms.TextBox textRemoteIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button colorblue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button colorpink;
        private System.Windows.Forms.Button colorgray;
        private System.Windows.Forms.Button colorsea;
        private System.Windows.Forms.Button colorturquise;
        private System.Windows.Forms.Button schat;
        private System.Windows.Forms.Button browseFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sendFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button receiveFile;
    }
}

