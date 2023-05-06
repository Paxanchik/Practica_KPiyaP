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

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\Учёба\\Практика КПиЯП\\день 15\\example.txt";

            // Получение информации о файле и вывод ее на экран
            XXXFileInfo.GetFileInfo(filePath, pathLabel, sizeLabel, extensionLabel, createdLabel);
        }
    }
    class XXXFileInfo
    {
        public static void GetFileInfo(string filePath, Label pathLabel, Label sizeLabel, Label extensionLabel, Label createdLabel)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                // Полный путь к файлу
                pathLabel.Text = $"Полный путь: {fileInfo.FullName}";

                // Размер файла
                long fileSize = fileInfo.Length;
                sizeLabel.Text = $"Размер файла: {fileSize} байт";

                // Расширение и имя файла
                string extension = fileInfo.Extension;
                string fileName = fileInfo.Name;
                extensionLabel.Text = $"Расширение файла: {extension}";
                extensionLabel.Text = $"Имя файла: {fileName}";

                // Время создания файла
                DateTime createdTime = fileInfo.CreationTime;
                createdLabel.Text = $"Дата создания: {createdTime}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
