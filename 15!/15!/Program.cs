using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_
{
    class Program
    {
        int[] a = new int[3];
        public void generateArray()
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (int)(r.NextDouble() * 25);
            }
        }
        public void printArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public void bubbleSort()
        {
            for(int i = 0; i < a.Length; i ++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if(a[i] > a [j])
                    {
                        int t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
        public static void Main()
        {
            Program sort = new Program();
            sort.generateArray();
            sort.printArray();
            sort.bubbleSort();
            Console.WriteLine();
            sort.printArray();
            Console.ReadLine();
        }
    }
}
