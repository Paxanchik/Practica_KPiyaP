using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr13
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        List<School> schools = new List<School>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        void RefreshList<T>(ListBox listBox, List<T> ts)
        {
            listBox.Items.Clear();
            foreach (T t in ts)
            {
                string text = "";
                if (t is School school)
                {
                    text = $"{school.name} ({school.index})";
                }
                else if (t is Book book)
                {
                    text = $"{book.name} ({book.index})";
                }
                listBox.Items.Add(text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели текст");
                return;
            }
            books.Add(new Book(textBox1.Text, random.Next(100000)));
            RefreshList(listBox2, books);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы не ввели текст");
                return;
            }
            schools.Add(new School(textBox2.Text, random.Next(100000)));
            RefreshList(listBox1, schools);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var vibor = from school in schools from book in books select new { namesc = school.name, nameb = book.name };
            listBox3.Items.Clear();
            foreach (var v in vibor)
            {
                listBox3.Items.Add($"school {v.namesc,-30}  book {v.nameb}");                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали элемент");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            schools.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали элемент");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            books.RemoveAt(listBox1.SelectedIndex);
        }
    }
    class School
    {
        public string name;
        public int index;
        public School(string name,int ind) 
        { 
            this.name = name;
            this.index = ind;
        }
    }
    class Book
    {
        public string name;
        public int index;
        public Book(string name, int ind)
        {
            this.name = name;
            this.index = ind;
        }
    }
}
