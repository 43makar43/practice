using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class IO
    {
        public static bool ReadValue(string name,out int value, bool showMessage)
        {
            value = 0;
            //Приглашение ввода
            string format = "Введите {0}: ";
            Console.Write(string.Format(format, name));
            //Строка, содержащая значение
            string s = Console.ReadLine();
            // Получение числа
            bool r = int.TryParse(s, out value);

            if (r)
            {

                return true;
            }
            else
            {
                if (showMessage)
                    Console.WriteLine("Некоректное значение.");
                return false;
            }
        }
        public static bool ReadValue(string name, out double value, bool showMessage)
        {
            value = 0;
            //Приглашение ввода
            string format = "Введите {0}: ";
            Console.Write(string.Format(format, name));
            //Строка, содержащая значение
            string s = Console.ReadLine();
            // Получение числа
            bool r = double.TryParse(s, out value);

            if (r)
            {

                return true;
            }
            else
            {
                if (showMessage)
                    Console.WriteLine("Некоректное значение.");
                return false;
            }
        }

        public static bool WriteLine(string name, double value, int digits)
        {
            // Проверка исходных данных
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Не задано имя.");
                return false;
            }
             
            if(double.IsNaN(value) || double.IsInfinity(value))
            {

                Console.WriteLine("Не задано число.");
                return false;
            }

            if(digits<0)
            {
                Console.WriteLine("Отрицательное число цифр после запятой.");
                return false;
            }
            // Формат числа
            string f = "F" + digits.ToString();
            //Формат строки
            string format = "{0} = {1:"+f+"}";
            Console.WriteLine(string.Format(format, name, value));

            return true;
        }

        public static void WriteMatrix(double [][] matrix)
        {
            int m = matrix.Length;//число строк
            int n;//число столбцов
            for (int i = 0; i < m; i++)
            {
                n = matrix[i].Length;
                for (int j = 0; j < n-1; j++)
                {
                    Console.Write(matrix[i][j]);
                    Console.Write(' ');
                }
                Console.Write(matrix[i][n - 1]);
                Console.WriteLine();
            }
        }
    }
}
