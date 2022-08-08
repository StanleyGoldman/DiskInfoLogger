using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DiskInfoLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                if (item.IsReady)
                {
                    Console.WriteLine($"Name: {item.Name}. DriveType: {item.DriveType}. AvailableFreeSpace: {item.AvailableFreeSpace}. TotalFreeSpace: {item.TotalFreeSpace}. TotalSize: {item.TotalSize}. DriveFormat: {item.DriveFormat}.");
                }
            }
        }
    }
}
