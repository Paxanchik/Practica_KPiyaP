using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private XXXFileManager fileManager;

        public Form1()
        {
            InitializeComponent();
            fileManager = new XXXFileManager("D:\\", "D:\\Test");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateDirectory_Click_1(object sender, EventArgs e)
        {
            fileManager.CreateDirectoryAndFile();
            textBox1.AppendText("Директория XXXInspect и файл xxxdirinfo.txt созданы." + Environment.NewLine);
        }

        private void btnGetFiles_Click_1(object sender, EventArgs e)
        {
            string[] filesAndFolders = fileManager.GetFilesAndFolders();
            foreach (string fileOrFolder in filesAndFolders)
            {
                textBox1.AppendText(fileOrFolder + Environment.NewLine);
            }
        }

        private void btnCopyFiles_Click_1(object sender, EventArgs e)
        {
            string sourceDirPath = txtSourceDir.Text;
            string fileExtension = txtFileExtension.Text;
            fileManager.CopyFilesToXXXFiles(sourceDirPath, fileExtension);
            textBox1.AppendText($"Файлы с расширением {fileExtension} скопированы в директорию XXXFiles." + Environment.NewLine);
        }

        private void btnCreateArchive_Click_1(object sender, EventArgs e)
        {
            fileManager.CreateArchive();
            textBox1.AppendText("Создан архив из файлов директории XXXFiles." + Environment.NewLine);
        }

        private void btnExtractArchive_Click(object sender, EventArgs e)
        {
            fileManager.ExtractArchive();
            textBox1.AppendText("Архив разархивирован в директорию Test." + Environment.NewLine);
        }
    }

    public class XXXFileManager
    {
        private readonly string diskName;
        private readonly string xxxInspectPath;
        private readonly string xxxFilesPath;

        public XXXFileManager(string diskName, string xxxInspectPath)
        {
            this.diskName = diskName;
            this.xxxInspectPath = Path.Combine(xxxInspectPath, "XXXInspect");
            this.xxxFilesPath = Path.Combine(this.xxxInspectPath, "XXXFiles");
        }

        public string[] GetFilesAndFolders()
        {
            return Directory.GetFileSystemEntries(diskName);
        }

        public void CreateDirectoryAndFile()
        {
            Directory.CreateDirectory(xxxInspectPath);
            using (StreamWriter sw = File.CreateText(Path.Combine(xxxInspectPath, "xxxdirinfo.txt")))
            {
                sw.WriteLine("Список файлов и папок на диске:");
                string[] filesAndFolders = GetFilesAndFolders();
                foreach (string fileOrFolder in filesAndFolders)
                {
                    sw.WriteLine(fileOrFolder);
                }
            }
        }

        public void CopyFilesToXXXFiles(string sourceDirPath, string fileExtension)
        {
            Directory.CreateDirectory(xxxFilesPath);
            string[] sourceFiles = Directory.GetFiles(sourceDirPath, $"*.{fileExtension}");
            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destFile = Path.Combine(xxxFilesPath, fileName);
                File.Copy(sourceFile, destFile);
            }
        }
        public void CreateArchive()
        {
            string archivePath = Path.Combine(xxxInspectPath, "XXXFiles.zip");
            ZipFile.CreateFromDirectory(xxxFilesPath, archivePath);
            File.Delete(Path.Combine(xxxFilesPath, "file1.txt"));
            File.Delete(Path.Combine(xxxFilesPath, "file2.txt"));
            Directory.Delete(xxxFilesPath);
        }

        public void ExtractArchive()
        {
            string archivePath = Path.Combine(xxxInspectPath, "XXXFiles.zip");
            string extractPath = Path.Combine("D:\\", "Test", "XXXFilesExtracted");
            ZipFile.ExtractToDirectory(archivePath, extractPath);
        }
    }
}
