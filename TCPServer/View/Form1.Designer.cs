namespace TCPServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.btnRead = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtfreespace = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbSelectedVolume = new System.Windows.Forms.ComboBox();
            this.lbserinumber = new System.Windows.Forms.Label();
            this.lbl_BytesPerSector = new System.Windows.Forms.Label();
            this.lbl_TracksPerCylinder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(93, 85);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(114, 20);
            this.tbIP.TabIndex = 1;
            this.tbIP.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(91, 120);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(114, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "1234";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(225, 83);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(306, 82);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbStatus
            // 
            this.tbStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.Location = new System.Drawing.Point(225, 110);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(154, 39);
            this.tbStatus.TabIndex = 6;
            this.tbStatus.Text = "Server turn off";
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(43, 210);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.Size = new System.Drawing.Size(242, 213);
            this.dgvClient.TabIndex = 7;
            this.dgvClient.SelectionChanged += new System.EventHandler(this.dgvClient_SelectionChanged);
            // 
            // btnRead
            // 
            this.btnRead.Enabled = false;
            this.btnRead.Location = new System.Drawing.Point(306, 210);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.Location = new System.Drawing.Point(39, 176);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(122, 21);
            this.Clients.TabIndex = 9;
            this.Clients.Text = "Connection list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(443, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selected Volume";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCapacity);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtfreespace);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.txtFormat);
            this.panel2.Controls.Add(this.txtText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(446, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 198);
            this.panel2.TabIndex = 11;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(113, 159);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(164, 20);
            this.txtCapacity.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(13, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 16;
            this.label14.Text = "Capacity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(13, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Name";
            // 
            // txtfreespace
            // 
            this.txtfreespace.Location = new System.Drawing.Point(113, 122);
            this.txtfreespace.Name = "txtfreespace";
            this.txtfreespace.Size = new System.Drawing.Size(164, 20);
            this.txtfreespace.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(113, 88);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 20);
            this.txtType.TabIndex = 6;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(113, 51);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(164, 20);
            this.txtFormat.TabIndex = 5;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(113, 13);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(164, 20);
            this.txtText.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Free Space";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Format";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(680, 52);
            this.label12.TabIndex = 29;
            this.label12.Text = "Read hard drive information in workstations";
            // 
            // cbbSelectedVolume
            // 
            this.cbbSelectedVolume.FormattingEnabled = true;
            this.cbbSelectedVolume.Location = new System.Drawing.Point(559, 82);
            this.cbbSelectedVolume.Name = "cbbSelectedVolume";
            this.cbbSelectedVolume.Size = new System.Drawing.Size(167, 21);
            this.cbbSelectedVolume.TabIndex = 21;
            this.cbbSelectedVolume.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedVolume_SelectedIndexChanged);
            // 
            // lbserinumber
            // 
            this.lbserinumber.AutoSize = true;
            this.lbserinumber.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbserinumber.Location = new System.Drawing.Point(459, 349);
            this.lbserinumber.Name = "lbserinumber";
            this.lbserinumber.Size = new System.Drawing.Size(97, 17);
            this.lbserinumber.TabIndex = 30;
            this.lbserinumber.Text = "Serial Number";
            // 
            // lbl_BytesPerSector
            // 
            this.lbl_BytesPerSector.AutoSize = true;
            this.lbl_BytesPerSector.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_BytesPerSector.Location = new System.Drawing.Point(457, 383);
            this.lbl_BytesPerSector.Name = "lbl_BytesPerSector";
            this.lbl_BytesPerSector.Size = new System.Drawing.Size(107, 17);
            this.lbl_BytesPerSector.TabIndex = 31;
            this.lbl_BytesPerSector.Text = "Bytes per Sector";
            // 
            // lbl_TracksPerCylinder
            // 
            this.lbl_TracksPerCylinder.AutoSize = true;
            this.lbl_TracksPerCylinder.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_TracksPerCylinder.Location = new System.Drawing.Point(457, 425);
            this.lbl_TracksPerCylinder.Name = "lbl_TracksPerCylinder";
            this.lbl_TracksPerCylinder.Size = new System.Drawing.Size(116, 17);
            this.lbl_TracksPerCylinder.TabIndex = 32;
            this.lbl_TracksPerCylinder.Text = "Sector per cluster";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 514);
            this.Controls.Add(this.lbl_TracksPerCylinder);
            this.Controls.Add(this.lbl_BytesPerSector);
            this.Controls.Add(this.lbserinumber);
            this.Controls.Add(this.cbbSelectedVolume);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Clients);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Server";
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label Clients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtfreespace;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbSelectedVolume;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbserinumber;
        private System.Windows.Forms.Label lbl_BytesPerSector;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lbl_TracksPerCylinder;
    }
}

