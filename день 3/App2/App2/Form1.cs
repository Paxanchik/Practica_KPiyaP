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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text); 
            int y = Convert.ToInt32(textBox2.Text); 

            int q1x1 = 2; 
            int q1y1 = 3; 
            int q1x2 = 7; 
            int q1y2 = 6; 

            int q2x1 = 4; 
            int q2y1 = 1; 
            int q2x2 = 9; 
            int q2y2 = 4; 

            bool inQ1 = (x >= q1x1 && x <= q1x2 && y >= q1y1 && y <= q1y2);
            bool inQ2 = (x >= q2x1 && x <= q2x2 && y >= q2y1 && y <= q2y2);

            if (inQ1 && inQ2)
            {
                textBox3.Text = $"Точка A({x}, {y}) принадлежит и прямоугольнику Q1 и прямоугольнику Q2";
            }
            else if (inQ1)
            {
                textBox3.Text = $"Точка A({x}, {y}) принадлежит прямоугольнику Q1";
            }
            else if (inQ2)
            {
                textBox3.Text = $"Точка A({x}, {y}) принадлежит прямоугольнику Q2";
            }
            else
            {
                textBox3.Text = $"Точка A({x}, {y}) не принадлежит ни одному из прямоугольников Q1 и Q2";
            }
        }
    }
}
