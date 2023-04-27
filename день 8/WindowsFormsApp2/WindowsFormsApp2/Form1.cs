using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transport[] transports = new Transport[]
            {
                    new Car { Name = "BMW", PassengerCapacity = 5, CargoCapacity = 500, Speed = 120, CostPerKm = 10, NumberOfDoors = 4 },
                    new Bicycle { Name = "Author", PassengerCapacity = 1, CargoCapacity = 10, Speed = 20, CostPerKm = 0, NumberOfGears = 18 },
                    new Cart { Name = "Kustar", PassengerCapacity = 2, CargoCapacity = 200, Speed = 30, CostPerKm = 5, HorsePower = 1.5 }
            };
            foreach (Transport transport in transports)
            {
                string[] name = new string[] { $"Transport: {transport.Name}" };
                string[] PassengerCapacity = new string[] { $"Passenger Capacity: {transport.PassengerCapacity}" };
                string[] CargoCapacity = new string[] { $"Cargo Capacity: {transport.CargoCapacity}" };
                string[] Speed = new string[] { $"Speed: {transport.Speed} km/h" };
                string[] CostPerKm = new string[] { $"Cost per km: {transport.CostPerKm} rub" };
                string[] CalculateTime = new string[] { $"Time for 100 km: {transport.CalculateTime(100)} hours" };
                string[] CalculateCost = new string[] { $"Cost for 100 km with 3 passengers and 100 kg of cargo: {transport.CalculateCost(100, 3, 100)} rub" };
                listBox1.Items.AddRange(name);
                listBox1.Items.AddRange(PassengerCapacity);
                listBox1.Items.AddRange(CargoCapacity);
                listBox1.Items.AddRange(Speed);
                listBox1.Items.AddRange(CostPerKm);
                listBox1.Items.AddRange(CalculateTime);
                listBox1.Items.AddRange(CalculateCost);
                listBox1.Items.Add("");
            }
        }
    }
    abstract class Transport
    {
        public string Name { get; set; }
        public int PassengerCapacity { get; set; }
        public double CargoCapacity { get; set; }
        public double Speed { get; set; }
        public double CostPerKm { get; set; }

        public abstract double CalculateTime(double distance);
        public abstract double CalculateCost(double distance, int passengers, double cargo);
    }
    class Car : Transport
    {
        public int NumberOfDoors { get; set; }

        public override double CalculateTime(double distance)
        {
            return distance / this.Speed;
        }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            double cost = distance * this.CostPerKm;
            if (passengers > this.PassengerCapacity)
            {
                cost += (passengers - this.PassengerCapacity) * 100; // Дополнительная плата за пассажиров
            }
            if (cargo > this.CargoCapacity)
            {
                cost += (cargo - this.CargoCapacity) * 50; // Дополнительная плата за груз
            }
            return cost;
        }
    }
    class Bicycle : Transport
    {
        public int NumberOfGears { get; set; }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            return 0;
        }

        public override double CalculateTime(double distance)
        {
            return distance / this.Speed * 2; // Велосипед едет медленнее, поэтому удваиваем время
        }
    }
    class Cart : Transport
    {
        public double HorsePower { get; set; }
        public override double CalculateTime(double distance)
        {
            return distance / this.Speed * 1.5; // Повозка едет медленнее, поэтому увеличиваем время на полтора
        }

        public override double CalculateCost(double distance, int passengers, double cargo)
        {
            double cost = distance * this.CostPerKm;
            if (passengers > this.PassengerCapacity)
            {
                cost += (passengers - this.PassengerCapacity) * 50; // Дополнительная плата за пассажиров
            }
            if (cargo > this.CargoCapacity)
            {
                cost += (cargo - this.CargoCapacity) * 20; // Дополнительная плата за груз
            }
            return cost;
        }
    }
}
