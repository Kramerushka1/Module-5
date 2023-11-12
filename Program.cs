using System;
using System.Drawing;
using System.Globalization;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.5.3
        //Залейте упражнение в свой репозиторий в Git.

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

            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
    }
}