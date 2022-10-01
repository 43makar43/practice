using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praktika_Volkov_Makarov_
{
    public class OOP
    {
         public static void Task2()
        {
            //Задача 2.
            Vehicle v = new Vehicle("Транспортное средство", 20);
            AirVehicle a = new AirVehicle("Самолет", 10, 2);
            WaterVehicle w = new WaterVehicle("Корабль", 1000, 1000);
            LandVehicle l = new LandVehicle("Автомобиль", 10, 4);
            // Проверка типа транспортного средства 
            TestVehicle(v);
            TestVehicle(a);
            TestVehicle(w);
            TestVehicle(l);
        }
        public static void TestVehicle(Vehicle v)
        {
            Console.Write(v.Name);
            Console.Write(": ");
            if (v is AirVehicle)
            {
                Console.WriteLine("Воздушний транспорт");
            }
            else if (v is WaterVehicle)
            {
                Console.WriteLine("Водный транспорт");
            }
            else if (v is LandVehicle)
            {
                Console.WriteLine("Наземный транспорт");
            }
            else
            {
                Console.WriteLine("Транспортное средство общего вида");
            }
        }
    }
}
