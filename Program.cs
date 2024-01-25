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
            int[] array = GetArrayFromConsole();
            int[] sortedArray = SortArray(array);

            foreach (int num in sortedArray)
            {
                Console.Write($"{num} ");
            }
        }
        static int[] GetArrayFromConsole()
        {
            int[] result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите элемент массива номер {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
    }
}