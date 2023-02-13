using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac1_MDK0402
{
    public class Program
    {
       public static void Main(string[] args)
        {

            Console.Write("Введите сторону a = ");
            double a = Vvod();   
            Console.Write("Введите сторону b = ");
            double b = Vvod();
            Console.Write("Введите сторону c = ");
            double c = Vvod();

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Треугольник существует");

                if ((a == b) && (b == c))
                {
                    Console.WriteLine("Треугольник равносторонний");
                }
                else if ((a == b) || (a == c) || (b == c))
                {
                    Console.WriteLine("Треугольник равнобедренный");
                }
                else Console.WriteLine("Треугольник произвольный");

            }
            else Console.WriteLine("Треугольник не существует");
            Console.ReadKey();
        }

        static double Vvod()
        {
            while (true)
            {
                double i;
                if (double.TryParse(Console.ReadLine(), out i))
                    return i;
                else
                    Console.Write("Ошибка ввода! Введите еще раз: ");
            }
        }




    }


}
