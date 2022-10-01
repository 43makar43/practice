using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Praktika_Volkov_Makarov_
{
    public class dz
    {
        public static void Task1()
        {
            int[] x2 = new int[] { 25 };

            bool check = true;

            while (check == true)
            {
                int x;
                Console.WriteLine("Введите число: ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out x) == true)
                {
                    if (x != x2[0])
                    {
                        Console.WriteLine("Числа нет в массиве.");
                        check = true;
                    }

                    else
                    {
                        Console.WriteLine($"Вы ввели число которое есть в массиве");
                        check = false;
                    }
                }
                else
                {
                    Console.WriteLine("Некоректное значение.");
                    check = true;
                }


                

            }
        }
        public static void Task2()
        {
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            bool append = false;
            StreamWriter writer = new StreamWriter(fileName, append, Encoding.Default);

            double c0;
            Console.Write("Введите начальную сумму вклада: ");
            string str = Console.ReadLine();
            if (!double.TryParse(str, out c0) || c0 < 0)
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            double i;
            Console.Write("Введите ставку по вкладу: ");
            str = Console.ReadLine();
            if (!double.TryParse(str, out i) || i < 0)
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            int tmin;
            Console.Write("Введите минимальный срок вклада: ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out tmin) || tmin < 0)
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            int tmax;
            Console.Write("Введите максимальный срок вклада: ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out tmax) || tmax < 0)
            {
                Console.WriteLine("Некоректное значение.");
                return;
            }
            int dt;
            Console.Write("Введите шаг изменения срока: ");
            str = Console.ReadLine();
            if (!int.TryParse(str, out dt) || dt < 0)
            {
                Console.WriteLine("Некоректное значение.");
                return;                                   
            }
            while (tmin != tmax)
            {
                double ct = c0 * Math.Pow((1 + i / 100), tmin);
                tmin = tmin + dt;
                str = ct.ToString("F2");
                // Ввод строки в файл
                writer.WriteLine(str);
            }
            writer.Close();
        }
        public static void Task3()
        {

            //Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();

            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            string str;
            str = reader.ReadLine();          
            int n = int.Parse(str);

            string[] sub= new string[2];
            char[] del = { ' ' };
            double d = 0;
            double x = 0;
            double min;
            double max;
            double c;
            double[] a = new double [n];

            for (int i = 0; i < n; i++)
            {
                str = reader.ReadLine();
                sub = str.Split(del);
                a[i] = double.Parse(sub[1]);
                x = x + a[i];
            }
            x = x / n;
            

            for (int i = 0; i < n; i++)
            {             
                
                double y = (a[i] - x) * (a[i] - x);
                d = d + y;
            }
            d = d / (n - 1);
            c = Math.Sqrt(d);
            min = a[0];
            max = a[0];

            for (int i = 0; i < n; i++)
            {               
                
                if (max<a[i])   
                {
                    max = a[i];
                }
                else if (min > a[i])
                {
                    min = a[i];
                }

            }
            IO.WriteLine("Среднее значение", x, 2);
            IO.WriteLine("Дисперсия", d, 2);
            IO.WriteLine("Стандартное отклонение", c, 2);
            IO.WriteLine("Наибольшее значение", max, 2);
            IO.WriteLine("Наименьшее значение", min, 2);
        }
    }
}
