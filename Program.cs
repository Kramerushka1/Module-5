using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Module_5
{
    class Program
    {
        public static void Main (string[] args)
        {
            string[] favcolors = new string[3];
            for(int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            
            Console.WriteLine();

            Console.WriteLine("Your colors are:");
            foreach (string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }
        }
        static string ShowColor()
        {
            
            Console.WriteLine("Write your favorite color: ");
            string color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    YourColorIs();
                    Red();
                    break;

                case "green":
                    YourColorIs();
                    Green();
                    break;

                case "cyan":
                    YourColorIs();
                    Cyan();
                    break;

                default:
                    YourColorIs();
                    DefaultColor();
                    break;
            }
            Console.WriteLine();
            return color;
        }
        static void YourColorIs()
        {
            Console.WriteLine("Your color is ");
        }
        static void ResetColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Red()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("red");
            ResetColor();
        }
        static void Green()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("green");
            ResetColor();
        }
        static void Cyan()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("cyan");
            ResetColor();
        }
        static void DefaultColor()
        {
            Console.WriteLine("default");
        }
    }
}