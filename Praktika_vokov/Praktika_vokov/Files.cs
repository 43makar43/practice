using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Praktika_Volkov_Makarov_
{
    public class Files
    {
        public static void Task1()
        {
            //Задача 1. Запись строки в файл
            Console.WriteLine("Задача 1. Запись строки в файл");
            // Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            // Открытие файла для записи
            bool append = false;
            StreamWriter writer = new StreamWriter(fileName, append, Encoding.Default);
            // Ввод количесва строк
            int n;
            if (!IO.ReadValue("количесво строк", out n, true))
                return;

            // 2. Вывод данных в файл
            string str;
            for (int i = 0; i < n; i++)
            {
                // Ввод строки
                Console.Write("Введите строку: ");
                str = Console.ReadLine();
                // Ввод строки в файл
                writer.WriteLine(str);
            }
            // 3. Закрытие файла
            writer.Close();
            

        }
        public static void Task2()
        {
            //Задача 2. Чтение данных и файла
            Console.WriteLine("Задача 2. Чтение данных и файла");
            //Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            //1. Открытие файла
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            //2. Ввод данных из файла
            string str;
            while (!reader.EndOfStream)
            {
                // Ввод строки из файла
                str = reader.ReadLine();
                //Вывод строки в консоль
                Console.WriteLine(str);
            }
            //3. Закрытие файла
            reader.Close();

        }
        public static void Task3()
        {
            //Задача 3. Ввод матрици из файла
            Console.WriteLine("Задача 3. Ввод матрици из файла");
            //Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            //1. Открытие файла
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            //2. Ввод данных из файла
            // Размерность матрици
            string str = reader.ReadLine();
            char[] del = { ' ' };
            string[] sub = str.Split(del);
            int m = int.Parse(sub[0]);//Число строк
            int n = int.Parse(sub[1]);//число столбцов
            //Выделение памяти  для матрици
            double[][] a = new double[m][];
            for (int i = 0; i < m; i++)
            {
                a[i] = new double[n];
            }
            for (int i = 0; i < m; i++)
            {
                a[i] = new double[n];
            }
            // Вывод знацчений из файла
            for (int i = 0; i < m; i++)
            {
                str = reader.ReadLine();
                sub = str.Split(del);
                for (int j = 0; j < n; j++)
                {
                    a[i][j] = double.Parse(sub[j]);
                }
            }
            // 3. Закрытие файла
            reader.Close();
                //Вывод матрици в консоль
                IO.WriteMatrix(a);
            
        }
        public static void WriteMatrix(StreamWriter w, double [][] matrix)
        {          
            int m = matrix.Length;
            int n = matrix[0].Length;

            //размерность
            w.Write(m);
            w.Write(' ');
            w.WriteLine(n);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    w.Write(matrix[i][j]);
                    w.Write(' ');
                }
                w.WriteLine(matrix[i][n - 1]);
            }
        }
        public static void Task4()
        {
            //Матрица
            int m = 3;
            int n = 3;
            double[][] a = new double[m][];
            for (int i = 0; i < m; i++)
            {
                a[i] = new double[n];
            }
            //Элементы матрици
            a[0][0] = 1;
            a[0][1] = 2;
            a[0][2] = 3;
            a[1][0] = 8;
            a[1][1] = 9;
            a[1][2] = 4;
            a[2][0] = 7;
            a[2][1] = 6;
            a[2][2] = 5;
            // Ввод имени файла
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            // Открытие файла для записи
            bool append = false;
            StreamWriter writer = new StreamWriter(fileName, append, Encoding.Default);

            //2. Запись матрици в файл
            WriteMatrix(writer, a);
            //3. Закрытие файла
            writer.Close();
            //Проверка
            Console.WriteLine();
            Console.WriteLine("Проверка");

            Task3();
        }
        public static void Task5()
        {
            //Задача 5. Ввод значений( имя = значение)
            //Ввод имени
            Console.WriteLine("Задача 5. Ввод значений( имя = значение)");
            string fileName;
            Console.Write("Введите имя файла: ");
            fileName = Console.ReadLine();
            //1. Открытие файла для записи           
            StreamReader reader = new StreamReader(fileName, Encoding.Default);
            //2. Ввод данныйх из файла
            double wigth = 0;
            double height = 0;
            int digits = 0;

            string str;
            string [] sub;
            char[] del = { '=' };
            while (!reader.EndOfStream)
            {
                str = reader.ReadLine();
                sub = str.Split(del);

                switch(sub[0].Trim())
                {
                    case "wigth":
                        {
                            double.TryParse(sub[1], out wigth);
                        }
                        break;
                    case "height":
                        {
                            double.TryParse(sub[1], out height);
                        }
                        break;
                    case "digits":
                        {
                            int.TryParse(sub[1], out digits);
                        }
                        break;

                }

            }
            reader.Close();
            double s = wigth * height;
            IO.WriteLine("Площадь прямоугольника", s, digits);

        }
    }
}
