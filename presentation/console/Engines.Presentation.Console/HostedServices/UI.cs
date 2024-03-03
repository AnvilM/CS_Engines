using Engines.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.Console.HostedServices
{
    public class UI
    {
        public static void Welcome()
        {
            System.Console.WriteLine("Выберите пункт меню для начала:");
            System.Console.WriteLine("1 - Добавить объект");
            System.Console.WriteLine("2 - Получить объект");
        }

        public static void Add() 
        {
            System.Console.WriteLine("Выберите объект:");
            System.Console.WriteLine("1 - Двигатель внутреннего сгорания");
            System.Console.WriteLine("2 - Дизельный двигатель");
            System.Console.WriteLine("2 - Реактивный двигатель");
        }

        public static string[] Engine()
        {
            System.Console.WriteLine("Введите тип топлива:");
            string FuelType = System.Console.ReadLine();
            System.Console.Clear();

            System.Console.WriteLine("Введите количество топлива:");
            string Fuel = System.Console.ReadLine();
            System.Console.Clear();

            return [FuelType, Fuel];
        }

        public static int[] ICE()
        {
            System.Console.WriteLine("Введите объём двигателя:");
            int Volume = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите мощность двигателя:");
            int Power = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите Обороты в минуту двигателя:");
            int RPM = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            return [Volume, Power, RPM];
        }

        public static int[] Disel()
        {
            System.Console.WriteLine("Введите объём двигателя:");
            int Volume = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите мощность двигателя:");
            int Power = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите Обороты в минуту двигателя:");
            int RPM = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            return [Volume, Power, RPM];
        }


        public static int[] Jet()
        {
            System.Console.WriteLine("Введите тягу двигателя:");
            int Traction = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите разгон двигателя:");
            int Overclocking = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            System.Console.WriteLine("Введите Эксплуатационную продолжительность двигателя:");
            int Operational_duration = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Clear();

            return [Traction, Overclocking, Operational_duration];
        }


    }
}
