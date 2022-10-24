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
            this.txtPartitions = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_BytesPerSector = new System.Windows.Forms.Label();
            this.lbl_TracksPerCylinder = new System.Windows.Forms.Label();
            this.lbl_SectorsPerTrack = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCylinders = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHeads = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSectors = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTracks = new System.Windows.Forms.TextBox();
            this.txtSelectedDisk = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tbStatus.Font = new System.Drawing.Font("Blackadder ITC", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selected Disk";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPartitions);
            this.panel2.Controls.Add(this.txtCapacity);
            this.panel2.Controls.Add(this.txtSerialNumber);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(446, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 162);
            this.panel2.TabIndex = 11;
            // 
            // txtPartitions
            // 
            this.txtPartitions.Location = new System.Drawing.Point(113, 122);
            this.txtPartitions.Name = "txtPartitions";
            this.txtPartitions.Size = new System.Drawing.Size(164, 20);
            this.txtPartitions.TabIndex = 7;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(113, 88);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(164, 20);
            this.txtCapacity.TabIndex = 6;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(113, 51);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(164, 20);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(113, 13);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 20);
            this.txtType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Partitions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Serial Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_BytesPerSector);
            this.panel3.Controls.Add(this.lbl_TracksPerCylinder);
            this.panel3.Controls.Add(this.lbl_SectorsPerTrack);
            this.panel3.Location = new System.Drawing.Point(446, 337);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 100);
            this.panel3.TabIndex = 19;
            // 
            // lbl_BytesPerSector
            // 
            this.lbl_BytesPerSector.AutoSize = true;
            this.lbl_BytesPerSector.Location = new System.Drawing.Point(3, 12);
            this.lbl_BytesPerSector.Name = "lbl_BytesPerSector";
            this.lbl_BytesPerSector.Size = new System.Drawing.Size(85, 13);
            this.lbl_BytesPerSector.TabIndex = 15;
            this.lbl_BytesPerSector.Text = "Bytes per Sector";
            // 
            // lbl_TracksPerCylinder
            // 
            this.lbl_TracksPerCylinder.AutoSize = true;
            this.lbl_TracksPerCylinder.Location = new System.Drawing.Point(3, 73);
            this.lbl_TracksPerCylinder.Name = "lbl_TracksPerCylinder";
            this.lbl_TracksPerCylinder.Size = new System.Drawing.Size(98, 13);
            this.lbl_TracksPerCylinder.TabIndex = 17;
            this.lbl_TracksPerCylinder.Text = "Tracks per Cylinder";
            // 
            // lbl_SectorsPerTrack
            // 
            this.lbl_SectorsPerTrack.AutoSize = true;
            this.lbl_SectorsPerTrack.Location = new System.Drawing.Point(3, 44);
            this.lbl_SectorsPerTrack.Name = "lbl_SectorsPerTrack";
            this.lbl_SectorsPerTrack.Size = new System.Drawing.Size(92, 13);
            this.lbl_SectorsPerTrack.TabIndex = 16;
            this.lbl_SectorsPerTrack.Text = "Sectors per Track";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(443, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cylinders";
            // 
            // txtCylinders
            // 
            this.txtCylinders.Location = new System.Drawing.Point(515, 283);
            this.txtCylinders.Name = "txtCylinders";
            this.txtCylinders.Size = new System.Drawing.Size(70, 20);
            this.txtCylinders.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(598, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Heads";
            // 
            // txtHeads
            // 
            this.txtHeads.Location = new System.Drawing.Point(656, 281);
            this.txtHeads.Name = "txtHeads";
            this.txtHeads.Size = new System.Drawing.Size(70, 20);
            this.txtHeads.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(447, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sectors";
            // 
            // txtSectors
            // 
            this.txtSectors.Location = new System.Drawing.Point(515, 307);
            this.txtSectors.Name = "txtSectors";
            this.txtSectors.Size = new System.Drawing.Size(70, 20);
            this.txtSectors.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(598, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tracks";
            // 
            // txtTracks
            // 
            this.txtTracks.Location = new System.Drawing.Point(656, 308);
            this.txtTracks.Name = "txtTracks";
            this.txtTracks.Size = new System.Drawing.Size(70, 20);
            this.txtTracks.TabIndex = 27;
            // 
            // txtSelectedDisk
            // 
            this.txtSelectedDisk.Location = new System.Drawing.Point(559, 79);
            this.txtSelectedDisk.Name = "txtSelectedDisk";
            this.txtSelectedDisk.Size = new System.Drawing.Size(164, 20);
            this.txtSelectedDisk.TabIndex = 28;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(786, 514);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSelectedDisk);
            this.Controls.Add(this.txtTracks);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSectors);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtHeads);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCylinders);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
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
            this.Name = "Form1";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtPartitions;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_BytesPerSector;
        private System.Windows.Forms.Label lbl_TracksPerCylinder;
        private System.Windows.Forms.Label lbl_SectorsPerTrack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCylinders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHeads;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSectors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTracks;
        private System.Windows.Forms.TextBox txtSelectedDisk;
        private System.Windows.Forms.Label label12;
    }
}

