using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Задача. Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine()); // задаем значение стороны квадрата
            double P = 4 * a; // находим периметр
            double S = Math.Pow(a, 2); // находим площадь в квадрате
            Console.WriteLine("Периметр квадрата: " + P);
            Console.WriteLine("Площадь квадрата: " + S);

            Console.WriteLine("2 Задача. Введите a и b: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine()); ;
            int temp = A;
            A = B;
            B = temp;
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);

            Console.WriteLine("3 Задача. Введите число больше 1000:");
            int num = Convert.ToInt32(Console.ReadLine()); ; // задаем значение числа
            int thousands = (num / 1000) % 10; // находим цифру разряда тысяч
            Console.WriteLine("Цифра разряда тысяч: " + thousands);
        }
    }
}
