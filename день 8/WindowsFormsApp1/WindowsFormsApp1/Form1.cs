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
        public abstract class Book
        {
            public string Code { get; set; }
            public string Author { get; set; }
            public string Title { get; set; }
            public int Year { get; set; }
            public string Publisher { get; set; }

            // абстрактный метод для получения информации о книге в виде строки
            public abstract string GetBookInfo();
        }
        public class Encyclopedia : Book
        {
            public string Topic { get; set; }

            public override string GetBookInfo()
            {
                return $"Encyclopedia: {Title} by {Author} ({Year}), Topic: {Topic}, Publisher: {Publisher}, Code: {Code}";
            }
        }

        public class Directory : Book
        {
            public string Category { get; set; }

            public override string GetBookInfo()
            {
                return $"Directory: {Title} by {Author} ({Year}), Category: {Category}, Publisher: {Publisher}, Code: {Code}";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // создаем экземпляр класса Справочник
            var directory = new Directory
            {
                Code = "D-123",
                Author = "John Doe",
                Title = "Programming Guide",
                Year = 2022,
                Publisher = "ACME Publishing",
                Category = "Programming"
            };

            // создаем экземпляр класса Энциклопедия
            var encyclopedia = new Encyclopedia
            {
                Code = "E-456",
                Author = "Jane Smith",
                Title = "World History",
                Year = 2021,
                Publisher = "XYZ Books",
                Topic = "History"
            };

            // выводим информацию о книгах в текстовом поле
            textBox1.Text = directory.GetBookInfo() + Environment.NewLine + Environment.NewLine;
            textBox1.Text += encyclopedia.GetBookInfo();
        }
    }
}
