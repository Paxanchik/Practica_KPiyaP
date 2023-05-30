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
        private SmartphoneFactory smartphoneFactory;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIPhone_Click(object sender, EventArgs e)
        {
            smartphoneFactory = new IPhoneFactory();
            smartphoneFactory.DisplaySmartphoneInfo();
        }

        private void btnSamsungGalaxy_Click(object sender, EventArgs e)
        {
            smartphoneFactory = new SamsungGalaxyFactory();
            smartphoneFactory.DisplaySmartphoneInfo();
        }
    }
    public interface ISmartphone
    {
        string GetModel();
        string GetProcessor();
        int GetRAM();
    }
    // Конкретный продукт
    public class IPhone : ISmartphone
    {
        public string GetModel()
        {
            return "iPhone X";
        }

        public string GetProcessor()
        {
            return "Apple A11 Bionic";
        }

        public int GetRAM()
        {
            return 3;
        }
    }
    // Конкретный продукт
    public class SamsungGalaxy : ISmartphone
    {
        public string GetModel()
        {
            return "Samsung Galaxy S20";
        }

        public string GetProcessor()
        {
            return "Qualcomm Snapdragon 865";
        }

        public int GetRAM()
        {
            return 8;
        }
    }
    // Создатель
    public abstract class SmartphoneFactory
    {
        public abstract ISmartphone CreateSmartphone();

        public void DisplaySmartphoneInfo()
        {
            ISmartphone smartphone = CreateSmartphone();
            MessageBox.Show($"Model: {smartphone.GetModel()}\nProcessor: {smartphone.GetProcessor()}\nRAM: {smartphone.GetRAM()} GB");
        }
    }

    // Конкретный создатель
    public class IPhoneFactory : SmartphoneFactory
    {
        public override ISmartphone CreateSmartphone()
        {
            return new IPhone();
        }
    }
    // Конкретный создатель
    public class SamsungGalaxyFactory : SmartphoneFactory
    {
        public override ISmartphone CreateSmartphone()
        {
            return new SamsungGalaxy();
        }
    }
}
