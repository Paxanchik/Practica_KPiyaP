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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Задание_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var dirPath = "C:\\Users\\Admin\\Documents";
            var dirInfo = new XXXDirInfo(dirPath);

            textBox1.AppendText($"Files count: {dirInfo.GetFilesCount()}{Environment.NewLine}");
            textBox1.AppendText($"Creation time: {dirInfo.GetCreationTime()}{Environment.NewLine}");
            textBox1.AppendText($"Subdirectories count: {dirInfo.GetSubdirectoriesCount()}{Environment.NewLine}");

            var parents = dirInfo.GetParentDirectories();
            textBox1.AppendText("Parent directories:");
            foreach (var parent in parents)
            {
                textBox1.AppendText($" {parent}");
            }
        }
    }

    class XXXDirInfo
    {
        private readonly string _dirPath;

        public XXXDirInfo(string dirPath)
        {
            _dirPath = dirPath;
        }

        public int GetFilesCount()
        {
            return Directory.GetFiles(_dirPath).Length;
        }

        public DateTime GetCreationTime()
        {
            return Directory.GetCreationTime(_dirPath);
        }

        public int GetSubdirectoriesCount()
        {
            return Directory.GetDirectories(_dirPath).Length;
        }

        public string[] GetParentDirectories()
        {
            var parents = new List<string>();
            var parent = Directory.GetParent(_dirPath);

            while (parent != null)
            {
                parents.Add(parent.FullName);
                parent = parent.Parent;
            }

            return parents.ToArray();
        }
    }
}
