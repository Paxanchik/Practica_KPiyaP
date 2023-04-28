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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем новый экземпляр Word
            Word word = new Word(2019);

            // Создаем новый вирус и запускаем его
            Virus virus = new Virus();
            virus.Infect(textBox1);

            // Создаем новый экземпляр CConficker и запускаем его
            CConficker cconficker = new CConficker();
            cconficker.Infect(textBox2);

            // Создаем новый экземпляр Minesweeper и запускаем игру
            Minesweeper minesweeper = new Minesweeper();
            minesweeper.Play(textBox3);

            // Создаем нового разработчика и пусть он разработает новое ПО
            Developer developer = new Developer("Иван Иванов");
            Software software = new Software("Новая программа", 1);
            developer.DevelopSoftware(software, textBox4);
        }
    }

    public abstract class OperationSet
    {
        public abstract void AddOperation(string operationName);
        public abstract void RemoveOperation(string operationName);
    }
    public class TextProcessor
    {
        private OperationSet _operationSet;

        public TextProcessor(OperationSet operationSet)
        {
            _operationSet = operationSet;
        }

        public void AddOperation(string operationName)
        {
            _operationSet.AddOperation(operationName);
        }

        public void RemoveOperation(string operationName)
        {
            _operationSet.RemoveOperation(operationName);
        }
    }
    public class Software
    {
        private string _name;
        private int _version;

        public Software(string name, int version)
        {
            _name = name;
            _version = version;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Version
        {
            get { return _version; }
        }
    }
    public class Word : Software
    {
        public Word(int version) : base("Microsoft Word", version)
        {
        }
    }
    public class Virus
    {
        public virtual void Infect(TextBox textBox)
        {
            textBox.Text = ("Компьютер заражен вирусом.");
        }
    }
    public class CConficker : Virus
    {
        public override void Infect(TextBox textBox)
        {
           textBox.Text = ("Компьютер заражен вирусом Conficker.");
        }
    }

    // Класс, представляющий игрушку
    public class Toy
    {
        public virtual void Play(TextBox textbox)
        {
            textbox.Text = ("Игрушка играет.");
        }
    }

    // Класс, представляющий игру Сапер
    public class Minesweeper : Toy
    {
        public override void Play(TextBox textbox)
        {
            textbox.Text = ("Игра Сапер запущена.");
        }
    }
    public class Developer
    {
        private string _name;

        public Developer(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public void DevelopSoftware(Software software, TextBox textbox)
        {
            textbox.Text = ($"{_name} разработал новое программное обеспечение: {software.Name} версии {software.Version}.");
        }
    }
}