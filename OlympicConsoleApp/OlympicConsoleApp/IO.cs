using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicConsoleApp
{
    public class IO
    {
        public static bool GetData(List<int> list)
        {
            // очистка списка
            list.Clear();

            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Введена пустая строка");
                return false;
            }
            // разделение строки на подстроки по символу-разделителю
            char[] del = { ' ' };
            string[] sub = str.Split(del);
            // проверка наличия подстрок
            if (sub == null || sub.Length == 0)
                return false;

            int temp;
            bool res = true;
            for (int i = 0; i < sub.Length; i++)
            {
                if (string.IsNullOrEmpty(sub[i]) ||
                    string.IsNullOrWhiteSpace(sub[i]))
                    continue;
                // попытка преобразовать
                if (int.TryParse(sub[i], out temp))
                    list.Add(temp);
                else
                {
                    // в случае, если не удалось преобразовать строку в число
                    res = false;
                    Console.WriteLine("Введено некорректное значение: " +
                        sub[i]);
                    break;
                }
            }

            return res;
        }

        public static bool GetData(List<double> list)
        {
            // очистка списка
            list.Clear();

            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Введена пустая строка");
                return false;
            }
            // разделение строки на подстроки по символу-разделителю
            char[] del = { ' ' };
            string[] sub = str.Split(del);
            // проверка наличия подстрок
            if (sub == null || sub.Length == 0)
                return false;

            double temp;
            bool res = true;
            for (int i = 0; i < sub.Length; i++)
            {
                if (string.IsNullOrEmpty(sub[i]) ||
                    string.IsNullOrWhiteSpace(sub[i]))
                    continue;
                // попытка преобразовать
                if (double.TryParse(sub[i].Replace('.', ','), out temp))
                    list.Add(temp);
                else
                {
                    // в случае, если не удалось преобразовать строку в число
                    res = false;
                    Console.WriteLine("Введено некорректное значение: " +
                        sub[i]);
                    break;
                }
            }

            return res;
        }

        public static string Format(double value, int digits,
            bool replace)
        {
            string format = "F" + digits.ToString();
            string result = value.ToString(format);
            if (replace)
                return result.Replace(',', '.');
            else
                return result;
        }

        public static bool GetCheckMateStep(out string figure,// фигура
            out char col1, out int row1, // начальная позиция
            out char col2, out int row2) // конечная позиция
        {
            figure = string.Empty;
            col1 = 'A';
            row1 = 1;
            col2 = 'A';
            row2 = 1;

            // строка в шахматной нотации
            // e2 - e4
            // K g1 - f3
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str) ||
                string.IsNullOrWhiteSpace(str))
                return false;
            // удаление пробелов
            str = RemoveBlanks(str);

            // разделение строки по символу '-'
            char[] del1 = { '-' };
            string[] sub1 = str.Split(del1);

            // конечная позиция
            string finish = sub1[1].Trim();
            if (!GetPosition(finish, out col2, out row2))
            {
                return false;
            }

            string start = sub1[0].Trim();// убрать пробелы
            if (start.Length == 2)
            {
                // начальная позиция для пешки
                if (!GetPosition(start, out col1, out row1))
                {
                    return false;
                }
            }
            else
            {
                // начальная позиция для неизвестной фигуры
                char[] del2 = { ' ' };
                string[] sub2 = start.Split(del2);
                if (sub2.Length == 2)
                {
                    // фигура
                    figure = sub2[0];
                    // уточнить!!!!
                    if (figure.ToUpper() != "К")// кириллицей
                        return false;
                    // позиция
                    start = sub2[1];
                    if (!GetPosition(start, out col1, out row1))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;// непонятно что
                }
            }
            /*
            for (int i = 0; i < sub1.Length; i++)
                Console.WriteLine(sub1[i].Trim());// убрать пробелы слева и справа
            */
            return true;
        }

        public static bool GetPosition(string str, out char col,
            out int row)
        {
            // получить позицию из строки
            col = 'A';
            row = 1;

            if (str.Length != 2)
                return false;
            // проверка наличия столбца
            char[] chars = {'A','B','C','D','E','F','G','H',
                            'a','b','c','d','e','f','g','h'};

            if (chars.Contains(str[0]))
                col = str[0];
            else
                return false;

            // проверка строки
            if (char.IsDigit(str[1]))
            {
                row = int.Parse("" + str[1]);
                if (row == 0 || row == 9)
                    return false;
            }
            else
                return false;

            return true;
        }

        public static string RemoveBlanks(string str)
        {
            StringBuilder s = new StringBuilder();
            bool blank = true;// признак того, что пробел уже был

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    s.Append(str[i]);
                    blank = false;
                }
                else
                {
                    if (blank == false)
                    {
                        s.Append(str[i]);
                        blank = true;
                    }
                }
            }

            // получить строку
            string res = s.ToString();
            // убрать пробелы в конце
            return res.TrimEnd();
        }

        public static void WriteMatrix(int[][] a)
        {
            int m = a.Length;// количество строк
            int n;// количество столбцов
            for (int i = 0; i < m; i++)
            {
                n = a[i].Length;
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write(a[i][j]);
                    Console.Write(' ');
                }
                Console.Write(a[i][n - 1]);
                Console.WriteLine();
            }
        }
    }
}
