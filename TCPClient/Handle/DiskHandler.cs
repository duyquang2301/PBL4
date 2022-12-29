using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using TCPClient.Request;

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
        public DTOrequest getSerialNumberDTOrequest(DTOrequest data)
        {
           
            ManagementObjectSearcher diskInfors = new ManagementObjectSearcher("Select * from Win32_Diskdrive");
           
            foreach (ManagementObject diskInfo in diskInfors.Get())
            {
                data.SerialNumber = diskInfo["SerialNumber"].ToString();
            }
            return data;
        }
        public List<DTOrequest> getInfomationHardDisk()
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();
            DTOrequest serial = new DTOrequest();
            List<DTOrequest> hardDisks = new List<DTOrequest>();
            foreach (DriveInfo drive in driveInfo)
            {
                ulong sectorsPerCluster, bytesPerSector, numberOfFreeClusters, totalNumberOfClusters;
                GetDiskFreeSpace(drive.Name,
                                 out sectorsPerCluster,
                                 out bytesPerSector,
                                 out numberOfFreeClusters,
                                 out totalNumberOfClusters);
                var data = new DTOrequest();
                data.NameDisk = drive.Name;
                data.driveType = drive.DriveType.ToString();
                data.driveFormat = drive.DriveFormat;
                data.totalSize = drive.TotalSize;
                data.freeSpace = drive.TotalFreeSpace;
                data.SectorsPerCluster = sectorsPerCluster;
                data.BytesPerSector = bytesPerSector;
                getSerialNumberDTOrequest(data);
                hardDisks.Add(data);
            }
           
            return hardDisks;
        }
    }
}
