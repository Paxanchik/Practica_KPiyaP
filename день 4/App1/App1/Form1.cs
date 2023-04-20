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
            LoadMatrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int[] array = new int[n];
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = number; 
                number += 2;
            }
            for (int i = 0; i < n; i++)
            {
                textBox2.Text = $"Массив первых {n} положительных нечетных чисел:" + Convert.ToString(array[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] array = { 5, 8, 10, 3, 7, 2, 9, 6, 1, 4};
            textBox4.Text = string.Join(", ", array);
            int ak = 0; 
            bool found = false;

            for (int i = 0; i < 10; i++)
            {
                if (array[i] < array[6])
                {
                    ak = array[i];
                    found = true;
                    break;
                }
            }
            if (found)
            {
                textBox3.Text = "Первый элемент, удовлетворяющий условию: " + ak;
            }
            else
            {
                textBox3.Text = "Нет элементов, удовлетворяющих условию. Выводим 0.";
            }
        }
            private void LoadMatrix()
            {
                int[,] matrix = new int[8, 5]; 
                Random random = new Random();
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matrix[i, j] = random.Next(20, 41);
                    }
                }
                dataGridView1.RowCount = 8; 
                dataGridView1.ColumnCount = 5;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        dataGridView1[j, i].Value = matrix[i, j];
                    }
                }
            }
            private void button3_Click(object sender, EventArgs e)
            {
            int[,] matrix = new int[8, 5];
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(20, 41);
                }
            }
            int rowNumber = -1;
            for (int i = 0; i < 8; i++)
            {
                int countEven = 0;  
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0) 
                    {
                        countEven++; 
                    }
                }
                if (countEven >= 2) 
                {
                    rowNumber = i; 
                    break; 
                }
            }
            if (rowNumber != -1)
            {
                textBox6.Text = "Номер строки с не менее 2-х четных чисел: " + rowNumber;
            }
            else
            {
                textBox6.Text = "Строка с не менее 2-х четных чисел не найдена.";
            }
        }
    }
}
