using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mironchik
{
    class Program
    {
        static void Main(string[] args)
        {
            /*galactic galaxy = new galactic("Пенис", 120);
            galactic galaxy2 = new galactic("Книга", 120);

            Planet Earth = new Planet("Земля", 10, 1);
            Planet Saturn = new Planet("Сатурн", 950, 95);

            SelectGalaxy(galaxy);
            SelectGalaxy(galaxy2);

            SelectPlanet(Earth);
            SelectPlanet(Saturn);*/

            int s = 0;

            Console.Write("Введите размер массива: ");
            int lengthArray = int.Parse(Console.ReadLine());

            Planet[] planetArray = new Planet[lengthArray];

            for (int i = 0; i < lengthArray; i++)
            {
                Console.Write("Введите название планеты:");
                string name = Console.ReadLine();

                Console.Write("Введите массу планеты:");
                int mass = int.Parse(Console.ReadLine());

                Console.Write("Введите земныеМассы планеты:");
                int earthMass = int.Parse(Console.ReadLine());

                Planet NewPlanet = new Planet(name, mass, earthMass);

                planetArray.SetValue(NewPlanet, i);
                s += earthMass;

                Console.WriteLine("Добавлен элемент в массив\n");

            }

            for (int i = 0; i < planetArray.Length; i++)
            {
                SelectPlanet(planetArray[i]);
            }

            Console.WriteLine($"Общая масса планет: {s}");
            Console.WriteLine($"Количество элементов массива: {lengthArray}");

            Console.ReadLine();
        }
        public static void SelectGalaxy(galactic g)
        {
            if (g is galactic)
            {
                Console.WriteLine($"Имя: {g.name}. Масса: {g.Mass}. МаксМасса: {g.MaxValue}.");
            }
        }
        public static void SelectPlanet(Planet p)
        {
            if (p is galactic)
            {
                Console.WriteLine($"Имя: {p.name}. Масса: {p.Mass}. ЗемныхМасс: {p.EarthMass}.");
            }
        }
    }
}
