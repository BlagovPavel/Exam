using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивыы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество строк: ");
            Int32.TryParse(Console.ReadLine(), out int n);
            Console.Write("Количество столбцов: ");
            Int32.TryParse(Console.ReadLine(), out int m);
            int[,] matrix = new int[n, m];

            Random rand = new Random();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-5, 15);
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Количество отрицательных элементов: {count}");
            {
                int x = int.Parse(Console.ReadLine());
                int[] a = new int[x];
                int sum = 0;
                int i = 0;
                for (i = 0; i >= 0 && i <= x; i++) ;
                if ((a[i] >= 0) && (a[i] <= x))
                {
                    sum += a[i];
                }
                Console.WriteLine("Сумма = ", sum);
            }
                Console.ReadKey();
        }
    }
}
