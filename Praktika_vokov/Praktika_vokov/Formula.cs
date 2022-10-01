using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class Formula
    {
        public static void Task1()
        {
            // Задача 1
            Console.WriteLine("Задача 1. Нахождение площади треугольника по катетам.");
            double a = 5;
            double b = 2;
            double s = 0.5 * a * b;
            Console.WriteLine("Площадь треугольника: " + s +"\n");
            //Console.WriteLine("Площадь треугольника:");
            //Console.WriteLine(s);
        }
        public static void Task2()
        {
            // Задача 2 - Площадь окружности
            Console.WriteLine("Задача 2. Нахождение площади окружности по радиусу.");
            double r =5;
            double S = Math.PI * r * r;
            Console.Write("При радиусе "+r);
            Console.WriteLine(" площадь окружности: " + S +"\n");

        }
        public static void Task3()
        {
            // Задача 3 - площадь окуржности. Частный случай r=0
            Console.WriteLine("Задача 3. Нахождение площади окружности по радиусу.");
            double r = 5;
            double S ;
            r = Math.Abs(r);
            if(r==0)
            {
                S = 0;
            }
            else
            {
                S = Math.PI * r * r;
            }
            Console.Write("При радиусе " + r);
            Console.WriteLine(" площадь окружности: " + S +"\n");
        }
        public static void Task4()
        {
            // Задача 4. Площадь окружности с формированием вывода
            Console.WriteLine("Задача 4. Нахождение площади окружности по радиусу с формированием вывода.");
            double r = 5;
            double S;
            r = Math.Abs(r);
            if (r == 0)
            {
                S = 0;
            }
            else
            {
                S = Math.PI * r * r;
            }
            string format = "При радиусе {0} площадь окружности: {1:F2} \n"; //F- количество чисел после запятой
            Console.WriteLine(string.Format(format, r, S));
        }
        public static void Task5()
        {
            // Задача 5. Падение тела в условия земной гравитации
            Console.WriteLine("Задача 5. Падение тела в условия земной гравитации.");
            double h;
            const double g = 9.81;
            Console.Write("Введите высоту(м):");
            string s = Console.ReadLine();
            if (double.TryParse(s, out h) == false)
            {
                Console.WriteLine("Значение высоты введено некоректно");
                return;
            }
            if (h < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            double t = Math.Sqrt(2 * h / g);
            string format = (" Время подения составляет {0:F3} c.\n");
            Console.WriteLine(string.Format(format, t));
        }
        public static void Task6()
        {
            // Задача 6. Площадь равнобокой трапеции
            Console.WriteLine("Задача 6. Площадь равнобокой трапеции");
            double a;
            double b;
            double alpha;
            Console.Write("Введите большее основание: ");
            string str = Console.ReadLine();
            if (double.TryParse(str, out a) == false)
            { 
                Console.WriteLine("Значение большего основания введено некоректно");
                return;
            }
            if (a < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            Console.Write("Введите меньшее основание: ");
            string str0 = Console.ReadLine();
            if (double.TryParse(str0, out b) == false)
            {
                Console.WriteLine("Значение меньшего основания введено некоректно");
                return;
            }
            if (b < 0)
            {
                Console.WriteLine("Значение должно быть положительным");
                return;
            }
            Console.Write("Введите угол альфа: ");
            string str1 = Console.ReadLine();
            if (double.TryParse(str1, out alpha) == false)
            {
                Console.WriteLine("Значение альфа введено некоректно");
                return;
            }
            if (alpha < 0 || alpha > 90)
            {
                Console.WriteLine("Значение должно быть положительным и не больше 90 градусов");
                return;
            }
            alpha = alpha * Math.PI / 180;
            double s = 0.25 * (a * a - b * b) * Math.Tan(alpha);
            string format = ("Площадь трапеции равна: {0:F3}\n");
            Console.WriteLine(string.Format(format, s));

            
        }
        public static void Task7()
        {
            // Задача 7. Вычисление значения полинома
            Console.WriteLine("Задача 7. Вычисление значения полинома");
            double x;
            Console.Write("Введите x: ");
            string str = Console.ReadLine();
            if (!double.TryParse(str, out x))
            {
                Console.WriteLine("Некоректное значение.");
            }
            double y = 2 * x - 3;
            y = y * x + 2;
            y = y * x - 6;
            y = y * x + 1;
            string format = "y(x) = {0:F4}";
            Console.WriteLine(format, y);
        }
      
    }
}
