using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class Cycles
    {
        public static void Task1()
        {
            // Задача 1. Вычислиние 2^n
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if(n<1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double y = 2;
            for (int i = 1; i <= n-1; i++)
            {
                y = y * 2;
            }
            IO.WriteLine("y", y, 0);

        }
        public static void Task2()
        {
            //Задача 2. Ввычисление фактролиала
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double x = 1;
            for (int i = 2; i <= n; i++)
            {
                //x = x * i;
                x *= i;//Запони а то забудешь
            }
            IO.WriteLine("n! = ", x, 0);
        }
        public static void Task3()
        {
            //Задача 3. Вычисление произведений
            Console.WriteLine("Задача 3.Вычисление произведений");
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double x = 1.0 + 1.0 / (1.0 * 1.0);
            for (int i = 2; i <= n; i++)
            {
                x*= 1.0 + 1.0 / (i * i);
            }
            IO.WriteLine("x", x, 5);
        }
        public static void Task4()
        {
            //Задача 4. Вычисление n вложенных корней
            Console.WriteLine("Задача 4.Вычисление n вложенных корней");
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double x = Math.Sqrt(2);
            for (int i = 1; i <= n-1 ; i++)
            {
                x = Math.Sqrt(2 + x);
            }
            IO.WriteLine("x", x, 5);

        }
        public static void Task5()
        {
            //Задача 5. Вычисление частного произведения
            Console.WriteLine("Задача 5. Вычисление частного произведения");
            double x;
            if (!IO.ReadValue("x", out x, true))
            {
                return;
            }
            if (x < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double m = 2;
            double z = x - m;
            double y = z / (z + 1);
            for (int k = 1; k <= 5; k++)
            {
                m = m * 2;
                z = x - m;
                y = z * y / (z + 1);
            }
            IO.WriteLine("y", y, 5);
        }
        public static void Task6()
        {
            //Задача 6. Вычисление элементов последовательности
            Console.WriteLine("Задача 6. Вычисление элементов последовательности");
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double a = 1;
            for (int i = 1; i <= n; i++)
            {
                a = i * a + 1.0 / i;
            }
            string name = "a" + n.ToString();
            IO.WriteLine(name, a, 5);

        }
        public static void Task7()
        {
            //Задача 7. Вычисление элементов суммы произведения последовательности
            Console.WriteLine("Задача 7. Вычисление элементов суммы произведения последовательности");
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double a = 1;
            double b = 1;
            double s = a * b;
            double t;
            for (int k= 2; k <= n; k++)
            {
                t = a;
                a = 0.5 * (Math.Sqrt(b) + 0.5 * Math.Sqrt(t));
                b = 2 * t * t + b;
                s = s + a * b;
            }
            IO.WriteLine("s", s, 5);
        }
        public static void Task8()
        {
            //Задача 8. Вычисление суммы элементов
            Console.WriteLine("Задача 8. Вычисление суммы элементов");
            int n;
            if (!IO.ReadValue("n", out n, true))
            {
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("Число должно быть больше или равно 1.");
                return;
            }
            double a = 1;
            double b = 1;
            double v1 = 2;
            double v2 = 1;
            double v3 = 1 + a * a + b * b;
            double s = v1 / (v3 * v2);
            double t;
            for (int k = 2; k <= n; k++)
            {
                v1 = 2 * v1;
                v2 = v2 * k;
                t = a;
                a = 3 * b + 2 * t;
                b = 2 * t + b;
                v3 = 1 + a * a + b * b;
                s = s + v1 / (v3 * v2);
            }
            IO.WriteLine("s", s, 5);
        }
        public static void Task9()
        {
            //Задача 9. Вычисление элемнтов последовательности
            Console.WriteLine("Задача 9. Вычисление элемнтов последовательности");
            double x;
            double a;
            double eps;
            if (!IO.ReadValue("x", out x, true)) return;
            if (!IO.ReadValue("a", out a, true)) return;
            if (!IO.ReadValue("eps", out eps, true)) return;
            double y0 = a;
            double y1;
            double z;
            int n = 0;
            do
            {
                y1 = 0.5 * (y0 + x / y0);
                z = Math.Abs(y1 * y1 - y0 * y0);
                y0 = y1;
                n++;
            } while (z>=eps);
            string name = "y" + n.ToString();
            IO.WriteLine(name, y1, 5);
        }
        public static void Task10()
        {
            //Задача 10
            Console.WriteLine("Задача 10. ");
            double v;
            double h;
            double hmax;
            double hmin;
            if (!IO.ReadValue("V", out v, true)) return;
            if (!IO.ReadValue("h", out h, true)) return;
            if (!IO.ReadValue("hmax", out hmax, true)) return;
            if (!IO.ReadValue("hmin", out hmin, true)) return;
            h = hmin;
            while (h <= hmax)
            {
                double R = Math.Sqrt(v / Math.PI * h);
                IO.WriteLine("h", h, 5);
                IO.WriteLine("R", R, 5);
            }
            
        }
        public static void Task11()
        {
            double n;
            if (!IO.ReadValue("n", out n, true)) return;
            int b = 0;
            for (int k = 1; k <= n; k++)
            {
                double a;
                if (!IO.ReadValue("a", out a, true)) return;
                double t = a % 2;
                while (t != 0)
                {
                    b = b + 1;
                }

            }
            IO.WriteLine("b", b, 5);
        }
    }
}
