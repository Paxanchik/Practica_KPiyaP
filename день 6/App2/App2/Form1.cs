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
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }
        private void RefreshStudentList()
        {
            // Очистка и обновление списка студентов на форме
            listBox1.Items.Clear();
            foreach (var student in students)
            {
                listBox1.Items.Add(student);
            }
        }
        private class Student
        {
            public string FullName { get; set; }
            public string Specialty { get; set; }
            public int Course { get; set; }
            public double GPA { get; set; }
            public int YearsOfWorkExperience { get; set; }

            public Student(string fullName, string specialty, int course, double gpa, int yearsOfWorkExperience)
            {
                FullName = fullName;
                Specialty = specialty;
                Course = course;
                GPA = gpa;
                YearsOfWorkExperience = yearsOfWorkExperience;
            }

            public override string ToString()
            {
                return $"{FullName} - {Specialty}, Курс {Course}, Средний балл: {GPA}, Стаж работы: {YearsOfWorkExperience} год(а)";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchPattern = textBoxSearchPattern.Text;
            string searchSpecialty = textBoxSearchSpecialty.Text;
            int searchCourse = Convert.ToInt32(numericUpDown1.Value);
            double searchMinGPA = Convert.ToDouble(textBoxSearchMinGPA.Text);
            double searchMaxGPA = Convert.ToDouble(textBoxSearchMaxGPA.Text);

            // Фильтрация студентов по параметрам поиска
            var filteredStudents = students.Where(student =>
                student.FullName.Contains(searchPattern) &&
                student.Specialty.Contains(searchSpecialty) &&
                student.Course == searchCourse &&
                student.GPA >= searchMinGPA &&
                student.GPA <= searchMaxGPA
            );

            // Сортировка студентов по стажу работы и курсу
            filteredStudents = filteredStudents.OrderBy(student => student.YearsOfWorkExperience)
                                             .ThenBy(student => student.Course);

            // Обновление списка студентов на форме
            listBox1.Items.Clear();
            foreach (var student in filteredStudents)
            {
                listBox1.Items.Add(student);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Очистка всех полей ввода
            textBoxSearchPattern.Text = string.Empty;
            textBoxSearchSpecialty.Text = string.Empty;
            numericUpDown1.Value = 0;
            textBoxSearchMinGPA.Text = string.Empty;
            textBoxSearchMaxGPA.Text = string.Empty;
            RefreshStudentList(); // Обновление списка студентов на форме
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students.Add(new Student("Иванов Иван Иванович", "Математика", 3, 4.5, 2));
            students.Add(new Student("Петров Петр Петрович", "Физика", 2, 3.8, 1));
            students.Add(new Student("Сидорова Елена Викторовна", "История", 4, 4.2, 3));
            students.Add(new Student("Смирнов Сергей Александрович", "Филология", 1, 3.5, 0));
            students.Add(new Student("Кузнецова Ольга Владимировна", "Экономика", 3, 4.0, 1));

            RefreshStudentList();
        }
    }
}