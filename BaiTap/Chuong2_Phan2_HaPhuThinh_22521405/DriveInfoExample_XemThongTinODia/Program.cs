﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveInfoExample_XemThongTinODia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine(" File type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine(" Volume label: {0}",
                   d.VolumeLabel);
                    Console.WriteLine(" File system: {0}",
                   d.DriveFormat);
                    Console.WriteLine(
                    " Available space to current user:{0, 15} bytes",
                    d.AvailableFreeSpace);
                    Console.WriteLine(" Total available space: {0, 15} bytes", d.TotalFreeSpace);
                    Console.WriteLine(
                    " Total size of drive: {0, 15} bytes",
                    d.TotalSize);
                    Console.ReadKey();
                }

            }
        }
    }
}
