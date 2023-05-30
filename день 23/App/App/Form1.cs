using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        private Hospital hospital;
        public Form1()
        {
            InitializeComponent();
            hospital = new Hospital();

            // Добавляем пациентов в больницу
            hospital.AddPatient(new Patient { Id = 1, Name = "Иванов Иван Иванович", DateOfBirth = new DateTime(1990, 5, 1), Diagnosis = "Грипп", IsAdmitted = true });
            hospital.AddPatient(new Patient { Id = 2, Name = "Петров Петр Петрович", DateOfBirth = new DateTime(1980, 12, 15), Diagnosis = "Ангина", IsAdmitted = true });
            hospital.AddPatient(new Patient { Id = 3, Name = "Сидоров Сидор Сидорович", DateOfBirth = new DateTime(1975, 8, 23), Diagnosis = "Простуда", IsAdmitted = false });
            hospital.AddPatient(new Patient { Id = 4, Name = "Кузнецова Екатерина Владимировна", DateOfBirth = new DateTime(1995, 3, 10), Diagnosis = "Перелом", IsAdmitted = false });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patients = hospital.GetPatients().Where(p => p.IsAdmitted);
            listBox1.Items.Clear();

            foreach (var patient in patients)
            {
                listBox1.Items.Add($"{patient.Name} ({patient.DateOfBirth.ToShortDateString()})");
            }
        }
    }
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Diagnosis { get; set; }
        public bool IsAdmitted { get; set; }
    }
    public class Hospital
    {
        private List<Patient> patients;

        public Hospital()
        {
            patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            patients.Remove(patient);
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }
    }
}
