using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox2.Text); 
            double v = 0.001; 

            double sum = 0; 
            double term = 1; 
            int n = 0; 

            while (Math.Abs(term) >= v)
            {
                sum += term; // добавляем текущий член ряда к сумме
                n++; // увеличиваем счетчик количества слагаемых

                // вычисляем следующий член ряда (-1)^(n-1) * x^(n-1)
                term = Math.Pow(-1, n - 1) * Math.Pow(x, n - 1);
            }

            textBox1.Text = $"Значение функции F({x}) с точностью {v} равно: {sum}";
        }
    }
}
