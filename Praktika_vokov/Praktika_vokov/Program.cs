using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Практики");
            Console.WriteLine("2.Д/З");
            double a = double.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    #region Програмирование формул
                    /* // Задача 1
                     Formula.Task1();
                     // Задача 2
                     Formula.Task2();
                     // Задача 3
                     Formula.Task3();
                     // Задача 4
                     Formula.Task4();
                     // Задача 5
                     Formula.Task5();
                     // Задача 6
                     Formula.Task6();
                     // Задача 7
                     Formula.Task7(); */
                    #endregion
                    #region Выбор (условие)
                    // Задача 1
                    //Selection.Task1();
                    // Задача 2
                    //Selection.Task2();
                    // Задача 3
                    //Selection.Task3();

                    #endregion
                    #region Циклы
                    // Задача 1
                    //Cycles.Task1();
                    // Задача 2
                    //Cycles.Task2();
                    // Задача 3
                    //Cycles.Task3();
                    // Задача 4
                    //Cycles.Task4();
                    // Задача 5
                    //Cycles.Task5();
                    // Задача 6
                    //Cycles.Task6();
                    // Задача 7
                    //Cycles.Task7();
                    // Задача 8
                    //Cycles.Task8();
                    // Задача 9
                    //Cycles.Task9();
                    // Задача 10
                    //Cycles.Task10();
                    // Задача 11
                    //Cycles.Task11();
                    #endregion
                    #region Работа с файлами
                    // Задача 1
                    //Files.Task1();
                    // Задача 2
                    //Files.Task2();
                    // Задача 3
                    //Files.Task3();
                    // Задача 4
                    //Files.Task4();
                    // Задача 5
                    //Files.Task5();
                    #endregion
                    #region ООБ
                    //Задача 1.
                    //
                    //Задача 2.
                    OOP.Task2();
                    #endregion

                    Console.ReadKey();
                    break;
                /*case 2:
                    //dz.Task1();
                    //dz.Task2();
                    dz.Task3();
                    Console.ReadKey();
                    break;*/
            }

           
        }
    }
}
