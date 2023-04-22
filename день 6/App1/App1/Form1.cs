using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

        public class Address
        {
            public string City { get; set; }
            public int Index { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string ApartmentNumber { get; set; }

            public bool CheckIndexFormat()
            {
                return true;
            }
            public bool CheckCityFormat()
            {
                return true;
            }
            public bool CheckStreetFormat()
            {
                return true;
            }
            public bool CheckHouseNumber()
            {
                return true;
            }
            public bool CheckApartmentNumber()
            {
                return true;
            }
        }

        public class Student
        {
            public string FullName { get; set; }
            public int Age { get; set; }
            public string Specialization { get; set; }
            public DateTime DateOfBirth { get; set; }
            public int Course { get; set; }
            public string Group { get; set; }
            public double AverageGrade { get; set; }
            public string Gender { get; set; }
            public Address Address { get; set; }

            public bool CheckFullNameFormat()
            {
                return true;
            }
            public bool CheckAgeRange()
            {
                return true;
            }
            public bool CheckSpecialization()
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                FullName = textBox1.Text,
                Age = Convert.ToInt32(textBox2.Text),
                Specialization = textBox3.Text,
                Address = new Address
                {
                    City = textBox4.Text,
                    Index = Convert.ToInt32(textBox5.Text),
                    Street = textBox6.Text,
                    HouseNumber = textBox7.Text,
                    ApartmentNumber = textBox8.Text
                }
            };
            if (student.CheckFullNameFormat())
            {
                textBox16.Text = "ФИО студента: " + student.FullName;
            }
            else
            {
                textBox16.Text = "Некорректный формат ФИО студента!";
            }
            if (student.CheckAgeRange())
            {
                textBox15.Text = "Возраст студента: " + student.Age + " лет";
            }
            else
            {
                textBox15.Text = "Некорректный возраст студента!";
            }
            if (student.CheckSpecialization())
            {
                textBox14.Text = "Специальность: " + student.Specialization;
            }
            else
            {
                textBox14.Text = "Некорректная специльность!";
            }
            if (student.Address.CheckIndexFormat())
            {
                textBox12.Text = "Индекс: " + student.Address.Index;
            }
            else
            {
                textBox12.Text = "Некорректный формат индекса!";
            }
            if (student.Address.CheckCityFormat())
            {
                textBox11.Text = "Улица: " + student.Address.Street;
            }
            else
            {
                textBox11.Text = "Некорректный формат улицы!";
            }
            if (student.Address.CheckHouseNumber())
            {
                textBox10.Text = "Номер дома: " + student.Address.HouseNumber;
            }
            else
            {
                textBox13.Text = "Некорректный формат номера дома!";
            }
            if (student.Address.CheckStreetFormat())
            {
                textBox13.Text = "Улица: " + student.Address.Street;
            }
            else
            {
                textBox13.Text = "Некорректный формат улицы!";
            }
            if (student.Address.CheckApartmentNumber())
            {
                textBox9.Text = "Номер квартиры: " + student.Address.ApartmentNumber;
            }
            else
            {
                textBox9.Text = "Некорректный формат номера квартиры!";
            }
        }
    }
}
