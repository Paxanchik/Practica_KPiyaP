using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 14.26;
            double y = -1.22;
            double z = 3.5 * (-100);
            double t = 2 * Math.Cos(x - (Math.PI / 6)) / (0.5 + Math.Pow(Math.Sin(y),2)) * (1 + (Math.Pow(z,2)) / (3 - (Math.Pow(z,2))) / 5);
            Console.WriteLine("Получилось число: ");
            Console.WriteLine(t);
        }
    }
}
