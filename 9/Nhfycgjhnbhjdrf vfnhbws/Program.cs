using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhfycgjhnbhjdrf_vfnhbws
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 n = 0, m = 0;
            Console.Write("Число строк :");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Число столпцов :");
            m = Int32.Parse(Console.ReadLine());
            int[,] mas = new int[n, m];

            Console.WriteLine("n = {0}, m = {1}", n, m);
            init_rand(mas);
            show(mas);
            transp(mas);
            Console.ReadKey();
        }

        static void init_rand(int[,] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(0, 100);
                }
        }

        static void show(int[,] mas)
        {
            Console.WriteLine("*************************************");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void transp(int[,] mas)
        {
            int[,] temp = new int[mas.GetLength(1), mas.GetLength(0)];

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    temp[i, j] = mas[j, i];
                }
                Console.WriteLine();
            }

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    Console.Write(temp[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
 
