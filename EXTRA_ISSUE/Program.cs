using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA_ISSUE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Определить является ли год високосным.");
            Tall_Year();
            Console.WriteLine("2.Какой четверти декартовых координат принадлежит точка.");
            Def_qr();
            Console.WriteLine("3.Попадает ли точка в окружность с центром(0; 0)");
            Def_circle();
            Console.WriteLine("3.Попадает ли точка в окружность с произвольным центром");
            Def_circle_pro();
           Console.Read();

        }
        
        static void Tall_Year()
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year%4==0 && year % 100 != 0 | year % 400 == 0)
            {
                Console.WriteLine("Год высокосный");                
            }
            else
            {
                Console.WriteLine("Неа), год не высокосный");
            }


        }
        static void Def_qr()
        {
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x>0 && y>0)
            {
                Console.WriteLine("Точка находится в первом квадранте");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во втором квадранте");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в третьем квадранте");
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("Точка находится в четвертом квадранте");
            }
            if (x == 0 | y == 0)
            {
                Console.WriteLine("Точка находится на одной из осей");
            }

        }
        static void Def_circle()
        {
            Console.WriteLine("Радиус окружности");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(R,2))
            {
                Console.WriteLine("Точка находится в окружности");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности");
            }
           

        }
        static void Def_circle_pro()
        {
            Console.WriteLine("Введите координату x_0 центра круга");
            double x_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y_0 центра круга");
            double y_0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус окружности");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(x-x_0, 2) + Math.Pow(y-y_0, 2) <= Math.Pow(R, 2))
            {
                Console.WriteLine("Точка находится в окружности");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности");
            }
        }

    }
}
