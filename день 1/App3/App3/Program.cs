using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Задача. Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine()); // задаем значение числа
            if (num > 0) // проверяем, является ли число положительным
            {
                num += 1; // прибавляем 1, если число положительное
            }
            Console.WriteLine("Результат: " + num);

            Console.WriteLine("2 Задача. Введите число: ");
            int N = Convert.ToInt32(Console.ReadLine()); // задаем номер арифметического действия (1 — сложение, 2 — вычитание, 3 — умножение, 4 — деление)
            double A = 5.5; // задаем значение первого числа
            double B = 2.5; // задаем значение второго числа
            double result = 0; // переменная для хранения результата
            switch (N)
            {
                case 1: // если N равно 1, то выполняем сложение
                    result = A + B;
                    break;
                case 2: // если N равно 2, то выполняем вычитание
                    result = A - B;
                    break;
                case 3: // если N равно 3, то выполняем умножение
                    result = A * B;
                    break;
                case 4: // если N равно 4, то выполняем деление
                    result = A / B;
                    break;
                default: // если N не соответствует ни одному из допустимых значений, то выводим ошибку
                    Console.WriteLine("Ошибка: недопустимое значение N");
                    break;
            }

            Console.WriteLine("Результат: " + result);

            Console.WriteLine("Введите число: ");
            int K = Convert.ToInt32(Console.ReadLine()); // задаем значение числа K
            Console.WriteLine("Введите колличество повторений: ");
            int f = Convert.ToInt32(Console.ReadLine()); // задаем количество повторений
            for (int i = 0; i < f; i++) // используем цикл для повторения вывода числа K N раз
            {
                Console.WriteLine(K);
            }

            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine()); // задаем значение числа
            while (m > 0) // используем цикл, пока число больше нуля
            {
                int digit = m % 10; // находим остаток от деления на 10 (это цифра разряда единиц)
                Console.Write(digit + " "); // выводим цифру
                m = m / 10; // делим число на 10 для перехода к следующей цифре
            }
        }
    }
}
