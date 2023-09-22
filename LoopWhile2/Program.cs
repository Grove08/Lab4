using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A (ширина прямоугольника):");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B (высота прямоугольника):");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C (сторона квадрата):");
            int C = Convert.ToInt32(Console.ReadLine());
            int D = 0;

            while (A >= C && B>=C)
            {
                A -= C;
                B -= C;
                D++;
            }
            Console.WriteLine("Максимальное количество квадратов, размещенных на прямоугольнике, равно {0}", D);
            Console.ReadKey();
        }
    }
}
