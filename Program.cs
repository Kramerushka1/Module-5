using System;
using System.Drawing;
using System.Globalization;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.3.13
        //Используйте код метода SortArray. Сейчас этот метод сортирует массив по возрастанию значения.
        //Создайте методы SortArrayDesc и SortArrayAsc — сортировка массива от большего к меньшему и сортировка массива от меньшего к большему.
        //
        //Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.
        //Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.
        //
        //Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sorted asc.



        public static void Main(string[] args)
        {
            
        }

        static int[] SortArrayDesc(int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }

            return array;
        }

        static int[] SortArrayAsc(int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }

            return array;
        }

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(array);
            sortedasc = SortArrayAsc(array);
        }

        static int[] GetArrayFromConsole()
        {
            int[] array = new int[4];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите {0} число: ", i + 1);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

    }
}