using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        private Stack<char> charStack = new Stack<char>();
        private List<char> charList = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            charStack.Push('a');
            charStack.Push('b');
            charStack.Push('c');
            charStack.Push('d');
            charStack.Push('e');

            DisplayStack();
        }
        private void DisplayStack()
        {
            char[] charArray = charStack.ToArray();
            string stackString = new string(charArray);
            StackLabel.Text = stackString;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = 2;
            for (int i = 0; i < n; i++)
            {
                charStack.Pop();
            }

            DisplayStack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            charStack.Push('f');
            charStack.Push('g');
            charStack.Push('h');

            DisplayStack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            charList.Add('f');
            charList.Add('g');
            charList.Add('h');

            DisplayList();
        }
        private void DisplayList()
        {
            string listString = new string(charList.ToArray());
            ListLabel.Text = listString;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = 2;
            charList.RemoveRange(charList.Count - n, n);

            DisplayList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            charList.Add('a');
            charList.Add('b');
            charList.Add('c');
            charList.Add('d');
            charList.Add('e');

            DisplayList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            charList.Clear();
            charList.AddRange(charStack);

            DisplayList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            char searchChar = 'c';
            int index = charList.IndexOf(searchChar);
            if (index == -1)
            {
                MessageBox.Show($"Character '{searchChar}' not found in the list.");
            }
            else
            {
                MessageBox.Show($"Character '{searchChar}' found at index {index} in the list.");
            }
        }
    }
}
