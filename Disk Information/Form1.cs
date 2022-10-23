using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk_Information
{  
    public partial class Form1 : Form
    {

        
        private bool IsInfoAvailiable = true;
        ManagementObjectSearcher diskInfors = new ManagementObjectSearcher("Select * from Win32_Diskdrive");
        public Form1()
        {
            InitializeComponent();
            setComboboxSelectedDisk();
            setCommboboxSelectedVolume();
            cbbSelectedDisk.SelectedIndex = 0;
            cbbSelectedVolume.SelectedIndex = 0;
        }
        void setComboboxSelectedDisk()
        {

            foreach (ManagementObject diskInfo in diskInfors.Get())
            {
                cbbSelectedDisk.Items.Add(diskInfo["Model"].ToString());
            }
        }
        void setCommboboxSelectedVolume()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                cbbSelectedVolume.Items.Add(drives[i].Name);
            }
        }
        private void cbbSelectedDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagementObjectSearcher diskInfors =
            new ManagementObjectSearcher("Select * from Win32_Diskdrive where Model = '" + cbbSelectedDisk.SelectedItem + "'");
            foreach (ManagementObject diskInfo in diskInfors.Get())
            {
                txtType.Text = diskInfo["MediaType"].ToString();
                txtSerialNumber.Text = diskInfo["SerialNumber"].ToString();
                txtCapacity.Text = FormatBytes((long)Convert.ToDouble(diskInfo["Size"]));
                txtPartitions.Text = diskInfo["Partitions"].ToString();
                txtCylinders.Text = diskInfo["TotalCylinders"].ToString();
                txtHeads.Text = diskInfo["TotalHeads"].ToString();
                txtSectors.Text = diskInfo["TotalSectors"].ToString();
                txtTracks.Text = diskInfo["TotalTracks"].ToString();
                lbl_BytesPerSector.Text = "Bytes per Sector: " + diskInfo["BytesPerSector"].ToString();
                lbl_SectorsPerTrack.Text = "Sectors per Track: " + diskInfo["SectorsPerTrack"].ToString();

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo driveInfo = null;
            if (cbbSelectedVolume.SelectedIndex != -1)
            {
                driveInfo = new DriveInfo(cbbSelectedVolume.Text);
                txtName.Text = driveInfo.Name;
                if (driveInfo.IsReady)
                {
                    if (driveInfo.VolumeLabel.Length > 0)
                    {
                        txtVolume.Text = driveInfo.VolumeLabel;
                    }
                    else
                    {
                        txtVolume.Text = "None";
                    }
                    txtFormat.Text = driveInfo.DriveFormat;
                    txtTypeVolume.Text = driveInfo.DriveType.ToString();
                    txtCapaityVolume.Text = FormatBytes(driveInfo.TotalSize);
                    txtFreeSpace.Text = FormatBytes(driveInfo.TotalFreeSpace);
                    txtUseSpace.Text = FormatBytes(driveInfo.TotalSize - driveInfo.TotalFreeSpace);
                }
                else
                {
                    IsInfoAvailiable = false;
                    txtFormat.Text = "";
                    txtTypeVolume.Text = "";
                    txtCapaityVolume.Text = "";
                    txtFreeSpace.Text = "";
                    txtUseSpace.Text = "";
                }
                if (IsInfoAvailiable == false)
                {
                    MessageBox.Show("Drive is not ready");
                }
            }
        }
        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }

    }
}
