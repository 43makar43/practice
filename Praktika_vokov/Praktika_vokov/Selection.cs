using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class Selection
    {
        public static void Task1()
        {
            // Задача 1. Поиск максимального элимента
            Console.WriteLine("Задача 1. Поиск максимального элимента");
            double x;
            Console.Write("Введите x: ");
            string str = Console.ReadLine();
            if(!double.TryParse(str, out x))
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            double y;
            Console.Write("Введите y: ");
            str = Console.ReadLine();
            if (!double.TryParse(str, out y))
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            double max;
            double min;
            if(x>y)
            {
                max = x;
                min = y;

            }
            else
            {
                max = y;
                min = x;
            }
            string format = "{0}({1},{2})={3}";
            Console.WriteLine(string.Format(format, "max", x, y, max));
            Console.WriteLine(string.Format(format, "min", x, y, min));
        }
        public static void Task2()
        {
            // Задача 2. Наибольшее и наименьшее Значение
            Console.WriteLine("Задача 2. Наибольшее и наименьшее Значение");
            // Ввод данных
            double x;
            if (!IO.ReadValue("x", out x, true)) return;

            double y;
            if (!IO.ReadValue("y", out y, true)) return;

            int digits;
            if (!IO.ReadValue("число цифр после запятой", out digits, true))
            return;
            // Вычисление 
            double s = 0.5 * (x + y);
            double p = 2 * x * y;
            if(x>y)
            {
                x = p;
                y = s;
            }
            else
            {
                x = s;
                y = p;
            }
            // Вывод результата
            IO.WriteLine("x", x, digits);
            IO.WriteLine("y", y, digits);

            // Проверка
            //IO.WriteLine("Число Пи", Math.PI, digits);

        }
        public static void Task3()
        {
            //Задача 3. Решение квадратного уровнения
            double a;
            double b;
            double c;
            double D;
            double x1, x2;
            double eps; //Малое число для сравнения
           //Ввод данных
            if (!IO.ReadValue("a", out a, true)) return;
            if (!IO.ReadValue("b", out b, true)) return;
            if (!IO.ReadValue("c", out c, true)) return;
            if (!IO.ReadValue("eps", out eps, true)) return;
            //Вычисления
            D = b * b - 4 * a * c;
            if(D>eps)
            {
                D = Math.Sqrt(D);
                x1 = (-b + D) / 2 * a;
                x2 = (-b - D) / 2 * a;
                IO.WriteLine("x1", x1, 4);
                IO.WriteLine("x2", x2, 4);
            }
            else if(D<-eps)
            {
                Console.WriteLine("Действительных корней нет.");
            }
            else
            {
                x1 = x2 = 0.5*-b / a;
               
                IO.WriteLine("x1", x1, 4);
                IO.WriteLine("x2", x2, 4);
            }


            //Вывод результата
        }
    }
}
