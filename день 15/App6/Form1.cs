using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Задание_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePath = "xxxlogfile.txt";
            List<string> results = new List<string>();
            int count = 0;
            string line;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (line.Contains(textBox1.Text) && line.Contains(textBox2.Text))
                    {
                        results.Add(line);
                        count++;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string result in results)
                {
                    writer.WriteLine(result);
                }
            }
            textBox3.Text = string.Join(Environment.NewLine, results);
            label1.Text = $"Количество записей: {count}";
        }
    }
}
