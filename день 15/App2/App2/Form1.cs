using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вывод информации о свободном месте на диске C:
            long freeSpace = XXXDiskInfo.GetFreeSpace("C:");
            textBox1.Text = ("Free space on drive C: " + freeSpace + " bytes");

            // Вывод файловой системы диска C:
            string fileSystem = XXXDiskInfo.GetFileSystem("C:");
            textBox2.Text = ("File system of drive C: " + fileSystem);

            // Вывод информации о каждом диске
            string allDrivesInfo = XXXDiskInfo.GetAllDrivesInfo();
            textBox3.Text = (allDrivesInfo);
        }
    }
    public class XXXDiskInfo
    {
        // Возвращает информацию о свободном месте на диске
        public static long GetFreeSpace(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            return drive.AvailableFreeSpace;
        }

        // Возвращает файловую систему диска
        public static string GetFileSystem(string driveName)
        {
            DriveInfo drive = new DriveInfo(driveName);
            return drive.DriveFormat;
        }

        // Возвращает информацию о каждом диске, включая имя, объем, доступный объем и метку тома
        public static string GetAllDrivesInfo()
        {
            string result = "";
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    result += "Drive name: " + drive.Name + "\n" +
                        "Drive volume label: " + drive.VolumeLabel + "\n" +
                        "Drive file system: " + drive.DriveFormat + "\n" +
                        "Drive total size: " + drive.TotalSize + " bytes\n" +
                        "Drive available space: " + drive.AvailableFreeSpace + " bytes\n\n";
                }
            }
            return result;
        }
    }
}
