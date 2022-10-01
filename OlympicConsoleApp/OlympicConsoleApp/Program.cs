using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlympicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 1
            //Example1();

            // Пример 2
            //Example2();

            // Пример 3
            //Example3();

            // Пример 4
            //Example4();

            // Пример 5
            //Example5();

            // Пример 6
            //Example6();

            // Пример 7
            //Example7();

            // Пример 8
            Example8();

            // Пример 9
            //Example9();

            // Пример 10
            //Example10();

            // Пример 11
            Example11();

            Console.WriteLine();
            Console.WriteLine("Нажмите клавишу для выхода...");
            Console.ReadKey();
        }

        public static void Example1()
        {
            // Ввод данных
            List<int> list = new List<int>();
            IO.GetData(list);

            Console.Write("Количество значений: ");
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);

            if (list.Count >= 2)
            {
                int m = list[0];
                int n = list[1];

                Console.Write("n = ");
                Console.WriteLine(n);

                Console.Write("m = ");
                Console.WriteLine(m);
            }
        }

        public static void Example2()
        {
            List<double> list = new List<double>();
            if (IO.GetData(list))
            {
                // данные загружены без ошибок
                Console.Write("Количество значений: ");
                Console.WriteLine(list.Count);
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine(list[i]);
            }
        }

        public static void Example3()
        {
            // Выводим число ПИ
            double value = Math.PI;

            string str = IO.Format(value, 3, false);
            Console.Write("PI = ");
            Console.WriteLine(str);

            str = IO.Format(value, 4, true);
            Console.Write("PI = ");
            Console.WriteLine(str);
        }

        public static void Example4()
        {
            // шахматы
            string figure;
            char col1;
            int row1;

            char col2;
            int row2;

            if (!IO.GetCheckMateStep(out figure, out col1, out row1,
                out col2, out row2))
            {
                Console.WriteLine("Шахматный ход введен неправильно!");
                return;
            }

            string step = string.Format("{0} {1}{2}-{3}{4}",
                figure, col1, row1, col2, row2);
            Console.Write("Шахматный ход: ");
            Console.WriteLine(step);
        }

        struct Command
        {
            public string name;
            public int score;

            public Command(string name, int score)
            {
                this.name = name;
                this.score = score;
            }

            public void Print()
            {
                Console.Write(name);
                Console.Write(' ');
                Console.WriteLine(score);
            }

            public static int CompareCommands(Command c1, Command c2)
            {
                // функция для сортировки
                int dif = c2.score - c1.score;// для чисел
                if (dif == 0)
                {
                    // сравниваем названия по алфавита
                    return string.Compare(c1.name.ToUpper(), c2.name.ToUpper());
                }
                else
                    return dif;
            }
        }

        public static void Example5()
        {
            // список команд
            List<Command> list = new List<Command>();
            list.Add(new Command("Зенит", 10));
            list.Add(new Command("Ростов", 7));
            list.Add(new Command("Ювентус", 12));
            list.Add(new Command("Реал", 10));

            // сортировка
            list.Sort(Command.CompareCommands);

            // вывод списка команд
            for (int i = 0; i < list.Count; i++)
                list[i].Print();

            // структуры
            Command temp = list[0];
            temp.score = 5;
            list[0] = temp;

            // классы
            //list[0].score = 5;

            // сортировка
            list.Sort(Command.CompareCommands);

            // вывод списка команд
            for (int i = 0; i < list.Count; i++)
                list[i].Print();
        }

        class Step
        {
            public int deltaCol;
            public int deltaRow;

            public Step(int deltaCol, int deltaRow)
            {
                this.deltaCol = deltaCol;
                this.deltaRow = deltaRow;
            }

            public static bool IsPossible(Step step)
            {
                if (step.deltaCol >= 0 && step.deltaCol < 8 &&
                    step.deltaRow >= 1 && step.deltaRow < 9)
                    return true;
                else
                    return false;
            }
        }

        class Figure
        {
            public string name;
            public int col;
            public int row;
            public bool first;

            public Figure(string name, int col, int row)
            {
                this.name = name;
                this.col = col;
                this.row = row;

                steps = new List<Step>();
                strikes = new List<Step>();
                first = false;
            }

            public bool Match(string name, int col, int row)
            {
                if (string.Equals(this.name.ToUpper(),
                    name.ToUpper()) && this.col == col &&
                    this.row == row)
                    return true;
                else
                    return false;
            }

            public List<Step> steps;
            public List<Step> strikes;

            public bool IsPossibleStep(int scol, int srow)
            {
                // TODO проверка возможного хода
                return true;
            }

            public void CreatePeshkaW()
            {
                // возможные шаги
                steps.Add(new Step(0, 2));
                steps.Add(new Step(0, 1));
                // возможные атаки
                strikes.Add(new Step(-1, 1));
                strikes.Add(new Step(1, 1));
            }

            public void CreatePeshkaB()
            {
                // возможные шаги
                steps.Add(new Step(0, -2));
                steps.Add(new Step(0, -1));
                // возможные атаки
                strikes.Add(new Step(-1, -1));
                strikes.Add(new Step(1, -1));
            }

            public void CreateHorse()
            {
                // возможные ходы
                steps.Add(new Step(-1, 2));
                steps.Add(new Step(1, 2));

                steps.Add(new Step(-1, -2));
                steps.Add(new Step(1, -2));
            }

            public void CreateLad()
            {
                // возможные ходы
                steps.Add(new Step(-1, 0));
                steps.Add(new Step(1, 0));
                steps.Add(new Step(0, -1));
                steps.Add(new Step(0, 1));
            }

            public void CreateSlon()
            {
                // возможные ходы
                steps.Add(new Step(-1, 1));
                steps.Add(new Step(-1, -1));
                steps.Add(new Step(1, -1));
                steps.Add(new Step(1, 1));
                steps.Add(new Step(-2, 2));
                steps.Add(new Step(-2, -2));
                steps.Add(new Step(2, -2));
                steps.Add(new Step(2, 2));
            }

            public void CreateFerz()
            {
                steps.Add(new Step(-1, 1));
                steps.Add(new Step(-1, -1));
                steps.Add(new Step(1, -1));
                steps.Add(new Step(1, 1));

                steps.Add(new Step(-2, 2));
                steps.Add(new Step(-2, -2));
                steps.Add(new Step(2, -2));
                steps.Add(new Step(2, 2));

                steps.Add(new Step(-3, 3));
                steps.Add(new Step(-3, -3));
                steps.Add(new Step(3, -3));
                steps.Add(new Step(3, 3));

                steps.Add(new Step(0, -1));
                steps.Add(new Step(0, 1));
                steps.Add(new Step(0, -2));
                steps.Add(new Step(0, 2));
            }

            public void CreateKing()
            {
                steps.Add(new Step(-1, 1));
                steps.Add(new Step(-1, -1));
                steps.Add(new Step(1, -1));
                steps.Add(new Step(1, 1));

                steps.Add(new Step(0, -1));
                steps.Add(new Step(0, 1));
            }
        }

        public static void Example6()
        {
            // шахматы
            #region Фигуры
            // белые фигуры
            List<Figure> wfigures = new List<Figure>();

            // пешки
            Figure f = new Figure(string.Empty, 0, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 1, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 2, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 3, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 4, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 5, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 6, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 7, 2);
            f.CreatePeshkaW();
            f.first = true;
            wfigures.Add(f);
            // ладьи
            f = new Figure("Л", 0, 1);
            f.CreateLad();
            wfigures.Add(f);

            f = new Figure("Л", 7, 1);
            f.CreateLad();
            wfigures.Add(f);

            // Кони
            f = new Figure("К", 1, 1);
            f.CreateHorse();
            f.first = true;
            wfigures.Add(f);

            f = new Figure("К", 6, 1);
            f.CreateHorse();
            f.first = true;
            wfigures.Add(f);

            // Слоны
            f = new Figure("С", 2, 1);
            f.CreateSlon();
            wfigures.Add(f);

            f = new Figure("С", 5, 1);
            f.CreateSlon();
            wfigures.Add(f);

            // Ферзь
            f = new Figure("Ф", 3, 1);
            f.CreateFerz();
            wfigures.Add(f);

            // Король
            f = new Figure("Кр", 4, 1);
            f.CreateKing();
            wfigures.Add(f);

            // черные фигуры
            List<Figure> bfigures = new List<Figure>();

            // пешки
            f = new Figure(string.Empty, 0, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 1, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 2, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 3, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 4, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 5, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 6, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);

            f = new Figure(string.Empty, 7, 7);
            f.CreatePeshkaB();
            f.first = true;
            wfigures.Add(f);
            // ладьи
            f = new Figure("Л", 0, 8);
            f.CreateLad();
            wfigures.Add(f);

            f = new Figure("Л", 7, 8);
            f.CreateLad();
            wfigures.Add(f);

            // Кони
            f = new Figure("К", 1, 8);
            f.CreateHorse();
            f.first = true;
            wfigures.Add(f);

            f = new Figure("К", 6, 8);
            f.CreateHorse();
            f.first = true;
            wfigures.Add(f);

            // Слоны
            f = new Figure("С", 2, 8);
            f.CreateSlon();
            wfigures.Add(f);

            f = new Figure("С", 5, 8);
            f.CreateSlon();
            wfigures.Add(f);

            // Ферзь
            f = new Figure("Ф", 3, 8);
            f.CreateFerz();
            wfigures.Add(f);

            // Король
            f = new Figure("Кр", 4, 8);
            f.CreateKing();
            wfigures.Add(f);
            #endregion

            // список всех занятых позиций
            List<Step> positions = new List<Step>();
            for (int i = 0; i < 8; i++)
            {
                positions.Add(new Step(i, 1));
                positions.Add(new Step(i, 2));
                positions.Add(new Step(i, 7));
                positions.Add(new Step(i, 8));
            }

            // считываем первый ход белых
            string wfigure;
            char wcol1;
            int wrow1;

            char wcol2;
            int wrow2;
            if (!IO.GetCheckMateStep(out wfigure, out wcol1, out wrow1,
                out wcol2, out wrow2))
            {
                Console.WriteLine("Шахматный ход введен неправильно!");
                return;
            }
            // считываем ход черных
            string bfigure;
            char bcol1;
            int brow1;

            char bcol2;
            int brow2;

            if (!IO.GetCheckMateStep(out bfigure, out bcol1, out brow1,
                out bcol2, out brow2))
            {
                Console.WriteLine("Шахматный ход введен неправильно!");
                return;
            }
            // определяем фигуру и положение белых
            // номера столбцов
            char[] chars = {'A','B','C','D','E','F','G','H',
                            'a','b','c','d','e','f','g','h'};
            Dictionary<char, int> cols = new Dictionary<char, int>();
            for (int i = 0; i < 8; i++)
            {
                cols.Add(chars[i], i);
                cols.Add(chars[i + 8], i);
            }
            // номера столбцов
            int iwcol1 = cols[wcol1];
            int iwcol2 = cols[wcol2];

            Figure wfirst = null;
            for (int i = 0; i < wfigures.Count; i++)
            {
                if (wfigures[i].Match(wfigure, iwcol1, wrow1))
                {
                    wfirst = wfigures[i];
                    break;
                }
            }
            if (wfirst == null)
            {
                Console.WriteLine("Ход не соответствует ни одной фигуре");
                return;
            }
            // Фигура найден
            Console.Write(
                string.IsNullOrEmpty(wfirst.name) ?
                "Пешка" : wfirst.name);
            Console.WriteLine(" " + wcol1.ToString() + wrow1.ToString());

            // определяем фигуру и положение черных
            // выбираем случайно фигуру
            // выбираем случайно ход фигуры
        }

        public static string GetStepString(string figure,
            char col1, int row1,
            char col2, int row2)
        {
            string res = string.Format("{0} {1}{2}-{3}{4}",
                figure, col1, row1, col2, row2);
            return res;
        }

        /// <summary>
        /// Получает коэффициенты прямой, проходящей через 
        /// точки (x0, y0) и (x1, y1)
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public static void Coeff(double x0, double y0,
            double x1, double y1, out double a, out double b, out double c)
        {
            // a*x + b*y + c = 0
            // y = (-c - a*x)/b = -c/b - a/b*x = d*x + e 
            // (x-x0)/(x1-x0) = (y-y0)/(y1-y0)
            // (x-x0)*(y1-y0)/(x1-x0) = y-y0
            // d = (y1-y0)/(x1-x0)
            // e = y0 - x0*d => y = d*x + e => -d*x + y - e = 0 =>
            // a = -d, b = 1, c = -e

            a = -(y1 - y0) / (x1 - x0);
            b = 1;
            c = -y0 - x0 * a;
        }

        public static int PointInArea(double a, double b, double c,
            double x, double y)
        {
            double d = a * x + b * y + c;
            if (d <= 0)
                return 1;
            else
                return 0;
        }

        public static double IntegralMonteKarlo(int N, double[] x, double[] y)
        {
            int m = x.Length - 1;
            // оценка коэффициентов
            double[] a = new double[m];// коэффициенты линии
            double[] b = new double[m];
            double[] c = new double[m];

            for (int i = 0; i < m; i++)
            {
                Coeff(x[i], y[i], x[i + 1], y[i + 1],
                    out a[i], out b[i], out c[i]);
            }
            int n = 0; // количество точек, попавших в область ниже линии
            double xp;// координаты точки - случайные
            double yp;// координаты точки - случайные
            Random rnd = new Random(DateTime.Now.Millisecond/*100*/);// генератор последовательности
                                                                     // случайных чисел
            double xmin = 0;
            double xmax = 10;
            double ymin = 0;
            double ymax = 2;
            double r; // случайное число
            for (int j = 0; j < N; j++)
            {
                // случайная точка в прямоугольнике
                r = rnd.NextDouble();
                xp = xmin + (xmax - xmin) * r;
                r = rnd.NextDouble();
                yp = ymin + (ymax - ymin) * r;

                for (int i = 0; i < m; i++)
                {
                    if (xp >= x[i] && xp <= x[i + 1])
                    {
                        n += PointInArea(a[i], b[i], c[i], xp, yp);
                        break;// выход из цикла по i
                    }
                }
            }
            // площадь
            double s = ((double)n / N) * (xmax - xmin) * (ymax - ymin);

            return s;
        }

        public static void Example7()
        {
            double a, b, c;
            // расчет коэффициентов
            Coeff(0, 0, 2, 1, out a, out b, out c);
            // проверка коэффициентов
            double d;
            d = a * 0 + b * 0 + c;
            d = a * 2 + b * 1 + c;
            // проверка попадания в область
            int k = PointInArea(a, b, c, 0.5, 0.1);

            // метод Монте-Карло
            List<int> list = new List<int>();
            if (!IO.GetData(list))
                return;

            double[] x = { 0, 2, 8, 10 };
            double[] y = { 0, 1, 2, 0 };
            if (list.Count > 0)
            {
                double s = IntegralMonteKarlo(list[0], x, y);
                Console.WriteLine(IO.Format(s, 2, true));
            }
        }

        public static void Example8()
        {
            // размерность матрицы
            List<int> list = new List<int>();
            if (!IO.GetData(list))
                return;
            if (list.Count < 2)
                return;

            // число строк и столбцов
            int m = list[0];
            int n = list[1];
            // многомерный массив
            /*
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                // новый список значений
                IO.GetData(list);
                if (list.Count < n)
                {
                    Console.WriteLine("Неверное количество элементов в строке");
                    return;
                }
                // копирование элементов списка в матрицу
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = list[j];
                }
            }
            */
            // ступенчатый многомерный массив
            int[][] b = new int[m][];
            for (int i = 0; i < m; i++)
            {
                b[i] = new int[n];
                // новый список значений
                IO.GetData(list);
                if (list.Count < n)
                {
                    Console.WriteLine("Неверное количество элементов в строке");
                    return;
                }
                // копирование элементов списка в матрицу
                for (int j = 0; j < n; j++)
                {
                    b[i][j] = list[j];
                }
            }
            // список списков
            /*
            List<List<int>> c = new List<List<int>>();
            List<int> row;
            for (int i = 0; i < m; i++)
            {
                // новый список значений
                IO.GetData(list);
                if (list.Count < n)
                {
                    Console.WriteLine("Неверное количество элементов в строке");
                    return;
                }
                row = new List<int>();
                // копирование элементов списка в матрицу
                for (int j = 0; j < n; j++)
                {
                    row.Add(list[j]);
                }
                c.Add(row);
            }
            int p = a[0, 0];
            p = b[0][0];
            p = c[0][0];*/
            //
            /*Console.WriteLine("Матрица");
            IO.WriteMatrix(b);*/

            int max;
            int p = 1;

            for (int j = 0; j < n; j++)
            {
                // поиск максимального элемента
                max = int.MinValue;
                for (int i = 0; i < m; i++)
                {
                    if (max < b[i][j])
                    {
                        max = b[i][j];
                    }
                }
                // вывод максимального элемента
                Console.Write(max);
                Console.Write(' ');
                // вычисление произведения
                p *= max;
            }
            Console.Write(p);
            Console.WriteLine();
        }

        public static void Example9()
        {
            // 1B - 43
            // 100 - 1034

            // 1. ввод числа в 12 системе
            string number12 = Console.ReadLine();

            // 2. преобразование из 12 в 10
            int number10 = From12to10(number12);

            // 3. преобразование из 10 в F
            string number5 = From10toF(number10, 2);

            Console.WriteLine(number5);
        }

        public static int From12to10(string number12)
        {
            int res = 0;// результат
            string s; // строка, содержащая цифру
            int value; // значение из цифры
            int mult = 1;

            for (int i = number12.Length - 1; i >= 0; i--)
            {
                if (number12[i] == 'A' || number12[i] == 'a')
                {
                    // буква A
                    value = 10;
                }
                else if (number12[i] == 'B' || number12[i] == 'b')
                {
                    // буква B
                    value = 11;
                }
                else if (char.IsDigit(number12[i]))
                {
                    // если цифра
                    s = string.Empty + number12[i];
                    value = int.Parse(s);
                }
                else
                {
                    return -1;// что-то неправильное
                }

                res += value * mult;
                mult *= 12;
            }

            return res;
        }

        public static string From10toF(int number10, int f)
        {
            StringBuilder str = new StringBuilder();
            int temp = number10;// целая часть
            int digit;// остаток

            while (temp > 0)
            {
                digit = temp % f;// остаток от деления
                str.Insert(0, digit);// вставка цифры в начало строки
                temp /= f;// деление на f (основание)
            }

            return str.ToString();
        }

        public static void Example10()
        {
            // ввод данных и проверка корректности значений
            List<int> data = new List<int>();
            if (!IO.GetData(data))
                return;
            if (data.Count < 2)
                return;
            if (data[0] < 1 && data[0] > 12)
                return;
            if (data[1] < 1 && data[1] > 12)
                return;

            // количество белых шашек
            int nw = data[0];
            // количество черных шашек
            int nb = data[1];

            // формирование поля для шашек 8х8
            char c1 = ' ';
            char c2 = '0';
            char t;
            char[] field = new char[64];
            for (int i = 0; i < field.Length; i++)
            {
                // расстановка клеток по строке
                if (i % 2 == 0)
                    field[i] = c1;
                else
                    field[i] = c2;
                //01234567
                //89
                // 0 0 0 0
                //0 0 0 0 
                // поменять местами символы, если новая строка
                if ((i + 1) % 8 == 0)
                {
                    t = c1;
                    c1 = c2;
                    c2 = t;
                }
            }

            // расстановка белых шашек
            FillPlaces(nw, 'Б', field);

            // расстановка черных шашек
            FillPlaces(nb, 'Ч', field);

            // вывод результата
            for (int i = 0; i < field.Length; i++)
            {
                Console.Write(field[i]);
                if ((i + 1) % 8 == 0)// перейти на новую строку
                    Console.WriteLine();
            }
        }

        public static void FillPlaces(int n, char p, char[] field)
        {
            int k = 0;
            int index;
            //Random rnd = new Random(100);
            Random rnd = new Random(DateTime.Now.Millisecond);

            while (k < n)
            {
                // случайное положение
                index = rnd.Next(0, field.Length);
                if (field[index] == '0')
                {
                    field[index] = p;
                    k++;
                }
            }
        }

        public static void Example11()
        {
            // Количество измерений
            List<int> data = new List<int>();
            if (!IO.GetData(data))
                return;
            if (data.Count == 0)
                return;
            int n = data[0];
            // измерения
            if (!IO.GetData(data))
                return;
            if (data.Count < n)
                return;

            // поиск значений
            double min = double.MaxValue;// +бесконечность
            int imin = -1;// несуществующий номер
            double s; // среднее
            double d; // разность по модулю между средним и 220
            for (int i = 0; i < n - 1; i++)
            {
                s = 0.5 * (data[i] + data[i + 1]); // среднее
                d = Math.Abs(s - 220); // разность
                if (min > d)
                {
                    min = d;
                    imin = i;
                }
            }
            // вывод результатов
            // номера найденных измерений
            Console.Write(imin + 1);
            Console.Write(' ');
            Console.WriteLine(imin + 1 + 1);
            // значений найденных измерений
            Console.Write(data[imin]);
            Console.Write(' ');
            Console.WriteLine(data[imin + 1]);
            // среднее
            s = 0.5 * (data[imin] + data[imin + 1]);
            Console.Write(IO.Format(s, 1, true));
            Console.Write(' ');
            Console.WriteLine(IO.Format(min, 1, true));
        }
    }
}
