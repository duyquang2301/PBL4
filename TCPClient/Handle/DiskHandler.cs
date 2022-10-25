using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TCPClient.Model;

namespace TCPClient
{
    public class DiskHandler
    {
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool GetDiskFreeSpace(string lpRootPathName,
                                         out ulong lpSectorsPerCluster,
                                         out ulong lpBytesPerSector,
                                         out ulong lpNumberOfFreeClusters,
                                         out ulong lpTotalNumberOfClusters);
        public HardDisk getSerialNumberHardDisk(HardDisk data)
        {
           
            ManagementObjectSearcher diskInfors = new ManagementObjectSearcher("Select * from Win32_Diskdrive");
           
            foreach (ManagementObject diskInfo in diskInfors.Get())
            {
                data.serialNumber = diskInfo["SerialNumber"].ToString();
            }
            return data;
        }
        public List<HardDisk> getInfomationHardDisk()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            HardDisk serial = new HardDisk();
            List<HardDisk> hardDisks = new List<HardDisk>();
            foreach (DriveInfo drive in driveInfo)
            {
                ulong sectorsPerCluster, bytesPerSector, numberOfFreeClusters, totalNumberOfClusters;
                GetDiskFreeSpace(drive.Name,
                                 out sectorsPerCluster,
                                 out bytesPerSector,
                                 out numberOfFreeClusters,
                                 out totalNumberOfClusters);
                var data = new HardDisk();
                data.physicalName = drive.Name;
                data.driveType = drive.DriveType.ToString();
                data.driveFormat = drive.DriveFormat;
                data.totalSize = drive.TotalSize;
                data.freeSpace = drive.TotalFreeSpace;
                data.sectorsPerClusters = sectorsPerCluster;
                data.bytesPerSectors = bytesPerSector;
                getSerialNumberHardDisk(data);
                hardDisks.Add(data);
            }
           
            return hardDisks;
        }
    }
}
