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
            int[] nums = GetArrayFromConsole();

            foreach (int num in nums)
            {
                Console.Write($"{num} ");
            }
        }
        static int[] GetArrayFromConsole()
        {
            int[] result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите элеиент массива номер {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}