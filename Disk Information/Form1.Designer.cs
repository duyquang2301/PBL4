using System.Windows.Forms;

namespace Disk_Information
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTypeVolume = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCapaityVolume = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFreeSpace = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUseSpace = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.cbbSelectedVolume = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_BytesPerSector = new System.Windows.Forms.Label();
            this.lbl_TracksPerCylinder = new System.Windows.Forms.Label();
            this.lbl_SectorsPerTrack = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPartitions = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTracks = new System.Windows.Forms.TextBox();
            this.txtHeads = new System.Windows.Forms.TextBox();
            this.txtSectors = new System.Windows.Forms.TextBox();
            this.txtCylinders = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSelectedDisk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtTracks);
            this.panel1.Controls.Add(this.txtHeads);
            this.panel1.Controls.Add(this.txtSectors);
            this.panel1.Controls.Add(this.txtCylinders);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbSelectedDisk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 481);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Location = new System.Drawing.Point(355, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 453);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cbbSelectedVolume);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(6, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(323, 414);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtTypeVolume);
            this.panel5.Controls.Add(this.Type);
            this.panel5.Controls.Add(this.txtVolume);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txtCapaityVolume);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.txtFreeSpace);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.txtUseSpace);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txtFormat);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.lbl_Name);
            this.panel5.Location = new System.Drawing.Point(20, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(298, 354);
            this.panel5.TabIndex = 21;
            // 
            // txtTypeVolume
            // 
            this.txtTypeVolume.Location = new System.Drawing.Point(94, 122);
            this.txtTypeVolume.Name = "txtTypeVolume";
            this.txtTypeVolume.Size = new System.Drawing.Size(188, 25);
            this.txtTypeVolume.TabIndex = 20;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Location = new System.Drawing.Point(23, 125);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(38, 17);
            this.Type.TabIndex = 19;
            this.Type.Text = "Type";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(94, 51);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(188, 25);
            this.txtVolume.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Volume";
            // 
            // txtCapaityVolume
            // 
            this.txtCapaityVolume.Location = new System.Drawing.Point(94, 233);
            this.txtCapaityVolume.Name = "txtCapaityVolume";
            this.txtCapaityVolume.Size = new System.Drawing.Size(188, 25);
            this.txtCapaityVolume.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 236);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Capacity";
            // 
            // txtFreeSpace
            // 
            this.txtFreeSpace.Location = new System.Drawing.Point(94, 196);
            this.txtFreeSpace.Name = "txtFreeSpace";
            this.txtFreeSpace.Size = new System.Drawing.Size(188, 25);
            this.txtFreeSpace.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Free Space";
            // 
            // txtUseSpace
            // 
            this.txtUseSpace.Location = new System.Drawing.Point(94, 157);
            this.txtUseSpace.Name = "txtUseSpace";
            this.txtUseSpace.Size = new System.Drawing.Size(188, 25);
            this.txtUseSpace.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Use Space";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(94, 87);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(188, 25);
            this.txtFormat.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Format";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 25);
            this.txtName.TabIndex = 8;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(23, 18);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(45, 17);
            this.lbl_Name.TabIndex = 8;
            this.lbl_Name.Text = "Name";
            // 
            // cbbSelectedVolume
            // 
            this.cbbSelectedVolume.FormattingEnabled = true;
            this.cbbSelectedVolume.Location = new System.Drawing.Point(114, 0);
            this.cbbSelectedVolume.Name = "cbbSelectedVolume";
            this.cbbSelectedVolume.Size = new System.Drawing.Size(188, 25);
            this.cbbSelectedVolume.TabIndex = 20;
            this.cbbSelectedVolume.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Selected Volume";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(35, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 120);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbl_BytesPerSector);
            this.panel3.Controls.Add(this.lbl_TracksPerCylinder);
            this.panel3.Controls.Add(this.lbl_SectorsPerTrack);
            this.panel3.Location = new System.Drawing.Point(9, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 100);
            this.panel3.TabIndex = 18;
            // 
            // lbl_BytesPerSector
            // 
            this.lbl_BytesPerSector.AutoSize = true;
            this.lbl_BytesPerSector.Location = new System.Drawing.Point(3, 12);
            this.lbl_BytesPerSector.Name = "lbl_BytesPerSector";
            this.lbl_BytesPerSector.Size = new System.Drawing.Size(107, 17);
            this.lbl_BytesPerSector.TabIndex = 15;
            this.lbl_BytesPerSector.Text = "Bytes per Sector";
            // 
            // lbl_TracksPerCylinder
            // 
            this.lbl_TracksPerCylinder.AutoSize = true;
            this.lbl_TracksPerCylinder.Location = new System.Drawing.Point(3, 73);
            this.lbl_TracksPerCylinder.Name = "lbl_TracksPerCylinder";
            this.lbl_TracksPerCylinder.Size = new System.Drawing.Size(126, 17);
            this.lbl_TracksPerCylinder.TabIndex = 17;
            this.lbl_TracksPerCylinder.Text = "Tracks per Cylinder";
            // 
            // lbl_SectorsPerTrack
            // 
            this.lbl_SectorsPerTrack.AutoSize = true;
            this.lbl_SectorsPerTrack.Location = new System.Drawing.Point(3, 44);
            this.lbl_SectorsPerTrack.Name = "lbl_SectorsPerTrack";
            this.lbl_SectorsPerTrack.Size = new System.Drawing.Size(114, 17);
            this.lbl_SectorsPerTrack.TabIndex = 16;
            this.lbl_SectorsPerTrack.Text = "Sectors per Track";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(35, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 187);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPartitions);
            this.panel2.Controls.Add(this.txtCapacity);
            this.panel2.Controls.Add(this.txtSerialNumber);
            this.panel2.Controls.Add(this.txtType);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 162);
            this.panel2.TabIndex = 0;
            // 
            // txtPartitions
            // 
            this.txtPartitions.Location = new System.Drawing.Point(113, 122);
            this.txtPartitions.Name = "txtPartitions";
            this.txtPartitions.Size = new System.Drawing.Size(164, 25);
            this.txtPartitions.TabIndex = 7;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(113, 88);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(164, 25);
            this.txtCapacity.TabIndex = 6;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(113, 51);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(164, 25);
            this.txtSerialNumber.TabIndex = 5;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(113, 13);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(164, 25);
            this.txtType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Partitions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // txtTracks
            // 
            this.txtTracks.Location = new System.Drawing.Point(254, 312);
            this.txtTracks.Name = "txtTracks";
            this.txtTracks.Size = new System.Drawing.Size(70, 25);
            this.txtTracks.TabIndex = 14;
            // 
            // txtHeads
            // 
            this.txtHeads.Location = new System.Drawing.Point(254, 267);
            this.txtHeads.Name = "txtHeads";
            this.txtHeads.Size = new System.Drawing.Size(70, 25);
            this.txtHeads.TabIndex = 13;
            // 
            // txtSectors
            // 
            this.txtSectors.Location = new System.Drawing.Point(115, 312);
            this.txtSectors.Name = "txtSectors";
            this.txtSectors.Size = new System.Drawing.Size(70, 25);
            this.txtSectors.TabIndex = 12;
            // 
            // txtCylinders
            // 
            this.txtCylinders.Location = new System.Drawing.Point(117, 267);
            this.txtCylinders.Name = "txtCylinders";
            this.txtCylinders.Size = new System.Drawing.Size(70, 25);
            this.txtCylinders.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tracks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Heads";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Sectors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cylinders";
            // 
            // cbbSelectedDisk
            // 
            this.cbbSelectedDisk.FormattingEnabled = true;
            this.cbbSelectedDisk.Location = new System.Drawing.Point(137, 30);
            this.cbbSelectedDisk.Name = "cbbSelectedDisk";
            this.cbbSelectedDisk.Size = new System.Drawing.Size(187, 25);
            this.cbbSelectedDisk.TabIndex = 1;
            this.cbbSelectedDisk.SelectedIndexChanged += new System.EventHandler(this.cbbSelectedDisk_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Disk";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(719, 515);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Disk Information";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbSelectedDisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPartitions;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTracks;
        private System.Windows.Forms.TextBox txtHeads;
        private System.Windows.Forms.TextBox txtSectors;
        private System.Windows.Forms.TextBox txtCylinders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_TracksPerCylinder;
        private System.Windows.Forms.Label lbl_SectorsPerTrack;
        private System.Windows.Forms.Label lbl_BytesPerSector;
        private System.Windows.Forms.Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtCapaityVolume;
        private Label label14;
        private TextBox txtFreeSpace;
        private Label label13;
        private TextBox txtUseSpace;
        private Label label12;
        private TextBox txtFormat;
        private Label label11;
        private TextBox txtName;
        private Label lbl_Name;
        private ComboBox cbbSelectedVolume;
        private Label label10;
        private TextBox txtVolume;
        private Label label15;
        private TextBox txtTypeVolume;
        private Label Type;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        #endregion
    }
}

