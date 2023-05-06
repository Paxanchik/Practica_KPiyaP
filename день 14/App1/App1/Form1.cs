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

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    // Создаем массив из 5 элементов и выводим количество элементов меньше 0.2
                    ArrayHandler arr1 = new ArrayHandler(5);
                    textBox1.Text = ($"Количество элементов меньше 0.2: {arr1.CountElementsLessThan0_2}");

                    // Создаем массив из 7 элементов, заполненный значениями членов ряда Тейлора для ln(x) при x=3
                    ArrayHandler arr2 = new ArrayHandler(7, 3);
                    textBox2.Text = ($"Количество элементов меньше 0.2: {arr2.CountElementsLessThan0_2}");

                // Выводим сумму модулей элементов, расположенных до первого нуля
                    textBox3.Text = ($"Сумма модулей элементов, расположенных до первого нуля: {arr2.SumOfModulusBeforeFirstZero()}");
                }
                catch (ArgumentException ex)
                {
                    textBox1.Text = ($"Ошибка: {ex.Message}");
                }
                catch (Exception ex)
                {
                    textBox1.Text = ($"Произошла ошибка: {ex.Message}");
                }

        }
    }
    public class ArrayHandler
    {
        private double[] array;

        // Конструктор, выделяющий память под заданное количество элементов массива
        public ArrayHandler(int length)
        {
            if (length <= 0)
                throw new ArgumentException("Длина массива должна быть положительным числом");

            array = new double[length];
        }

        // Конструктор, заполняющий заданное количество элементов массива значениями членов ряда Тейлора для функции ln x для заданного x
        public ArrayHandler(int length, double x)
        {
            if (length <= 0)
                throw new ArgumentException("Длина массива должна быть положительным числом");

            if (x <= 0)
                throw new ArgumentException("Аргумент функции ln(x) должен быть положительным числом");

            array = new double[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = Math.Pow(-1, i) * Math.Pow(x - 1, i + 1) / (i + 1);
            }
        }

        // Свойство, доступное только для чтения, для получения количества элементов массива, меньших 0.2
        public int CountElementsLessThan0_2
        {
            get
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0.2)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        // Метод, вычисляющий сумму модулей элементов, расположенных до (левее) первого элемента, равного нулю
        public double SumOfModulusBeforeFirstZero()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    break;
                }
                sum += Math.Abs(array[i]);
            }
            return sum;
        }
    }
}
