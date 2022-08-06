using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beK;
            bool beB;
            double k;
            double b;
            Console.WriteLine("Введите коэффициенты k и b уравнения 0 = kx+b");
            do
            {
                Console.Write("k = ");
                beK = double.TryParse(Console.ReadLine(), out k);
                if (!beK)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beK);
            do
            {
                Console.Write("b = ");
                beB = double.TryParse(Console.ReadLine(), out b);
                if (!beB)
                {
                    Console.WriteLine("Ошибка! Неверный формат данных. Попробуйте ещё раз.");
                }
            } while (!beB);

            LinearEquation linearEquation = new LinearEquation(k, b);
            Console.WriteLine();
            Console.WriteLine("Корень уравнения x = {0}", Math.Round(linearEquation.Root(), 3, MidpointRounding.AwayFromZero));
            Console.ReadKey();
        }
    }
}
