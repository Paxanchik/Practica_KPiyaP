using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string fileName = "D:\\Учёба\\Практика КПиЯП\\день 15\\myfile.txt";
            string filePath = "D:\\Учёба\\Практика КПиЯП\\день 15\\";
            string action = "Открытие файла";
            XXXLog log = new XXXLog("D:\\Учёба\\Практика КПиЯП\\день 15\\xxxlogfile.txt");
            log.WriteLog(action, fileName, filePath);
        }
    }
    public class XXXLog
    {
        private readonly string logFilePath;

        public XXXLog(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void WriteLog(string action, string fileName, string filePath)
        {
            try
            {
                // Добавляем запись в конец файла xxxlogfile.txt
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {action} - {fileName} ({filePath})");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка записи лог-файла: {ex.Message}");
            }
        }

        public string ReadLog()
        {
            try
            {
                // Считываем все содержимое файла xxxlogfile.txt
                using (StreamReader reader = new StreamReader(logFilePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка чтения лог-файла: {ex.Message}");
                return string.Empty;
            }
        }

        public string SearchLog(string searchString)
        {
            try
            {
                string result = string.Empty;
                // Считываем построчно файл xxxlogfile.txt и ищем заданную строку
                using (StreamReader reader = new StreamReader(logFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(searchString))
                        {
                            result += line + "\n";
                        }
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка поиска в лог-файле: {ex.Message}");
                return string.Empty;
            }
        }
    }
}
