using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static int CountSpaces(string input)
        {
            int spaceCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceCount++;
                }
            }

            return spaceCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int spaceCount = CountSpaces(input);

            richTextBox1.Text = "Количество пробелов: " + spaceCount;
        }
    }
}
