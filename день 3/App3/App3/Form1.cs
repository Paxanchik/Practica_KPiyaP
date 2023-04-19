using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text); 
                int c = Convert.ToInt32(textBox3.Text);
                double xStart = Convert.ToDouble(textBox4.Text); 
                double xEnd = Convert.ToDouble(textBox5.Text);
                double dX = Convert.ToDouble(textBox6.Text);

                textBox7.Text = " x | F(x) ";
                textBox7.Text = "------------";

                for (double x = xStart; x <= xEnd; x += dX)
                {
                    double result;
                    int aInt = (int)a;
                    int bInt = (int)b;
                    int cInt = (int)c;

                    if (((aInt & bInt) != 0) || ((aInt & cInt) != 0))
                    {
                        result = a * Math.Pow(x, 2) + b;
                    }
                    else if ((x > 0) && (b == 0))
                    {
                        result = (x - a) / (x - c);
                    }
                    else
                    {
                        result = x / c;
                    }

                    if (result % 1 == 0)
                    {
                        textBox7.Text = $"{x} | {result:F0}";
                    }
                    else
                    {
                        textBox7.Text = $"{x} | {result:F2}";
                    }
                }
            }
            catch (Exception ex)
            {
                textBox7.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
