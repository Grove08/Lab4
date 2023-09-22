using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 0;

            int C;
            do
            {
                Console.WriteLine("Введите число (0 для завершения): ");
                C = Convert.ToInt32(Console.ReadLine());
                if (C > 0)
                    A++;
                else if (C < 0)
                    B++;
            }                                      
            while (C !=0);
            Console.WriteLine("Количество положительных чисел: " + A);
            Console.WriteLine("Количество отрицательных чисел: " + B);
            if (A > B)
                Console.WriteLine("Положительные чисел больше");
            else if (A < C)
                Console.WriteLine("Отрицательных чисел больше");
            else
                Console.WriteLine("Количество положительных и отрицательных чисел равно");
            Console.ReadKey();
        }
    }
}
