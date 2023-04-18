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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox3.Text);
            double z = 3.5 * (-100);
            double t = 2 * Math.Cos(x - (Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (Math.Pow(z, 2)) / (3 - (Math.Pow(z, 2))) / 5);
            textBox1.Text = t.ToString();
        }
    }
}
