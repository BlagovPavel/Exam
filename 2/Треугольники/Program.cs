using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Треугольники
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строну а: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите строну b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите строну c: ");
            double c = double.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b))
                if (a == b && a == c && b == c)
                    Console.WriteLine("Равносторонний");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Равнобедренный");
                else
                    Console.WriteLine("Разносторонний");
            else
                Console.WriteLine("Не треугольник");
            Console.ReadKey();
        }
    }
}
