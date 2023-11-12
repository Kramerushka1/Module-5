using System;
using System.Drawing;
using System.Globalization;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.5.4
        //Пусть каждая строка окрашивается в новый цвет, связанный с глубиной deep.

        public static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var phrase = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(phrase, deep);

            Console.ReadKey();
        }

        static void Echo(string saidword, int deep)
        {
            var modif = saidword;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}