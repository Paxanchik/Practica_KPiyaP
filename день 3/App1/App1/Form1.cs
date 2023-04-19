using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b; 
                a = b; 
                b = remainder; 
            }
            return a; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            int nod = GCD(m, n);
            textBox3.Text = $"НОД({m}, {n}) = {nod}";
        }
    }
}
