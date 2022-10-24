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
        public HardDisk getSerialNumberHardDisk()
        {   
            ManagementObjectSearcher diskInfors = new ManagementObjectSearcher("Select * from Win32_PhysicalMedia");
            HardDisk data = new HardDisk();
            foreach (ManagementObject diskInfo in diskInfors.Get())
            {
                data = new HardDisk
                {
                    serialNumber = diskInfo["SerialNumber"].ToString(),
                };
            }
            return data;
        }   
        public HardDisk getInfomationHardDisk()
        {         
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            HardDisk data = new HardDisk();
            foreach (DriveInfo drive in driveInfo)
            {
                ulong sectorsPerCluster, bytesPerSector, numberOfFreeClusters, totalNumberOfClusters;
                GetDiskFreeSpace(drive.Name,
                                 out sectorsPerCluster,
                                 out bytesPerSector,
                                 out numberOfFreeClusters,
                                 out totalNumberOfClusters);
                data = new HardDisk
                {
                    physicalName = drive.Name,
                    driveType = drive.DriveType.ToString(),
                    driveFormat = drive.DriveFormat,
                    totalSize = drive.TotalSize,
                    freeSpace = drive.TotalFreeSpace,
                    sectorsPerClusters = sectorsPerCluster,
                    bytesPerSectors = bytesPerSector,
            };
            }
            return data;
        }
    }
}
