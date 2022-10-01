using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class Sort
    {
        public static bool QuickSort(int[] a, int p, int r)
        {
            return true;
        }

        public static bool BubbleSort(int[] a)
        {
            if (a == null)
                return false;

            int n = a.Length;
            int t;
            for (int k = 1; k <= n - 1; k++)
            {
                for (int i = 0; i < n - k; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                    }
                }
            }
            return true;
        }

        public static bool SortMax(int[] a)
        {
            if (a == null)
                return false;

            int max;
            int imax;
            int n = a.Length;
            for (int k = 1; k <= n; k++)
            {
                max = int.MinValue;
                imax = -1;
                for (int i = 0; i < n - k + 1; i++)
                {
                    if (max < a[i])
                    {
                        max = a[i];
                        imax = i;
                    }
                }
                a[imax] = a[n - k];
                a[n - k] = max;
            }
            return true;
        }

        public static void Task1()
        {
            // ввод данных
            Console.WriteLine("Сортировка с выбором наибольшего эллемента");
            int n;
            if (!IO.ReadValue("число элементов массива", out n, true))
                return;
            if (n < 1)
            {
                Console.WriteLine("Число элеменитов должно быть больше 0!");
                return;
            }

            // массив случайных чсел
            int[] a = new int[n];
            Random rnd = new Random(100);

            SortMax(a);
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 11);

            // Вывод результатов
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[");
                Console.Write(i);
                Console.Write("] =");
                Console.WriteLine(a[i]);
            }

            // вывод рез-та


        }

        public static void Task2()
        {
            // ввод данных
            Console.WriteLine("Сортировка пузырьком");
            int n;
            if (!IO.ReadValue("число элементов массива", out n, true))
                return;
            if (n < 1)
            {
                Console.WriteLine("Число элеменитов должно быть больше 0!");
                return;
            }

            // массив случайных чсел
            int[] a = new int[n];
            Random rnd = new Random(100);


            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(0, 11);

            BubbleSort(a);
            // Вывод результатов
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[");
                Console.Write(i);
                Console.Write("] =");
                Console.WriteLine(a[i]);
            }

            // вывод рез-та


        }
    }
}
