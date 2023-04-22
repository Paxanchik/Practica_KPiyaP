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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static string[] GetWordsByLength(string input, int length)
        {
            string[] words = input.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries); // Разбиваем строку на слова

            // Фильтруем слова по длине
            string[] result = Array.FindAll(words, word => word.Length == length);

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            int length = Convert.ToInt32(textBox2.Text);

            string[] words = GetWordsByLength(input, length);
            int count = words.Length;

            richTextBox1.AppendText("Слова, имеющие длину " + length + ":");
            foreach (string word in words)
            {
                richTextBox1.AppendText(" " + word);
            }

            richTextBox1.AppendText(Environment.NewLine + "Количество слов: " + count);
        }
    }
}
