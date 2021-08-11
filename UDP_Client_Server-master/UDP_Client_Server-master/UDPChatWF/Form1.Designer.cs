namespace UDPChatWF
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbip = new System.Windows.Forms.TextBox();
            this.tbsendport = new System.Windows.Forms.TextBox();
            this.tbrecPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radYourIp = new System.Windows.Forms.RadioButton();
            this.radLocalIp = new System.Windows.Forms.RadioButton();
            this.btnconnect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txbmessage = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.labelConn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(104, 21);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(235, 20);
            this.tbname.TabIndex = 0;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(69, 19);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(166, 20);
            this.tbip.TabIndex = 1;
            this.tbip.TextChanged += new System.EventHandler(this.tbip_TextChanged);
            // 
            // tbsendport
            // 
            this.tbsendport.Location = new System.Drawing.Point(104, 135);
            this.tbsendport.Name = "tbsendport";
            this.tbsendport.Size = new System.Drawing.Size(235, 20);
            this.tbsendport.TabIndex = 2;
            this.tbsendport.TextChanged += new System.EventHandler(this.tbsendport_TextChanged);
            // 
            // tbrecPort
            // 
            this.tbrecPort.Location = new System.Drawing.Point(104, 183);
            this.tbrecPort.Name = "tbrecPort";
            this.tbrecPort.Size = new System.Drawing.Size(235, 20);
            this.tbrecPort.TabIndex = 3;
            this.tbrecPort.TextChanged += new System.EventHandler(this.tbrecPort_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Your Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recieve Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLocalIp);
            this.groupBox1.Controls.Add(this.radYourIp);
            this.groupBox1.Controls.Add(this.tbip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(104, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор IP";
            // 
            // radYourIp
            // 
            this.radYourIp.AutoSize = true;
            this.radYourIp.Location = new System.Drawing.Point(6, 20);
            this.radYourIp.Name = "radYourIp";
            this.radYourIp.Size = new System.Drawing.Size(60, 17);
            this.radYourIp.TabIndex = 11;
            this.radYourIp.Text = "Your IP";
            this.radYourIp.UseVisualStyleBackColor = true;
            // 
            // radLocalIp
            // 
            this.radLocalIp.AutoSize = true;
            this.radLocalIp.Checked = true;
            this.radLocalIp.Location = new System.Drawing.Point(6, 48);
            this.radLocalIp.Name = "radLocalIp";
            this.radLocalIp.Size = new System.Drawing.Size(92, 17);
            this.radLocalIp.TabIndex = 12;
            this.radLocalIp.TabStop = true;
            this.radLocalIp.Text = "Use 127.0.0.1";
            this.radLocalIp.UseVisualStyleBackColor = true;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(104, 245);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(235, 23);
            this.btnconnect.TabIndex = 11;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(368, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(411, 186);
            this.listBox1.TabIndex = 12;
            // 
            // txbmessage
            // 
            this.txbmessage.Location = new System.Drawing.Point(368, 245);
            this.txbmessage.Name = "txbmessage";
            this.txbmessage.Size = new System.Drawing.Size(310, 20);
            this.txbmessage.TabIndex = 13;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(684, 245);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(95, 23);
            this.btnsend.TabIndex = 14;
            this.btnsend.Text = "Send message";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // labelConn
            // 
            this.labelConn.AutoSize = true;
            this.labelConn.ForeColor = System.Drawing.Color.Red;
            this.labelConn.Location = new System.Drawing.Point(13, 251);
            this.labelConn.Name = "labelConn";
            this.labelConn.Size = new System.Drawing.Size(62, 13);
            this.labelConn.TabIndex = 15;
            this.labelConn.Text = "Connected!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 292);
            this.Controls.Add(this.labelConn);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txbmessage);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbrecPort);
            this.Controls.Add(this.tbsendport);
            this.Controls.Add(this.tbname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "ChatClientServer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.TextBox tbsendport;
        private System.Windows.Forms.TextBox tbrecPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLocalIp;
        private System.Windows.Forms.RadioButton radYourIp;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txbmessage;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label labelConn;
    }
}

