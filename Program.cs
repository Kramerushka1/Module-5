using System;
using System.Drawing;
using System.Globalization;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.2.18.
        public static void Main(string[] args)
        {
            bool sort = true;
            int arrLength = 10;
            int[] array = GetArrayFromConsole(arrLength);
            
            Console.WriteLine();
            ShowArray(array, sort);
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        static int[] SortArray(int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        value = array[j];
                        array[j] = array[i];
                        array[i] = value;
                    }
                    else continue;
                }
            }

            return array;
        }

        static void ShowArray(int[] array, bool sort = false)
        {
            if (sort)
            {
                array = SortArray(array);
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

    }
}