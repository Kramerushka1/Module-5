using System;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.2.17
        //Создайте метод ShowArray с параметрами: массив чисел, признак сортировки логического типа, необязательный параметр, по умолчанию ЛОЖЬ.
        //Метод должен выводить массив на экран.
        //Если значение признака сортировки равно ИСТИНА, то предварительно массив нужно отсортировать.

        //Задание 5.2.18
        //Вызовите сначала метод заполнения данных массива размерности 10, а потом метод его вывода на экран с сортировкой.

        static int[] GetArrayFromConsole(int num = 5)
        {
            int[] result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static int[] SortArray(int[] arr)
        {
            int value = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(0); j++)
                {
                    if (arr[i] > arr[j])
                    {
                        value = arr[j];
                        arr[j] = arr[i];
                        arr[i] = value;
                    }
                }
            }

            return arr;
        }
        static void ShowArray(int[] arr, bool sort = false)
        {
            if (sort)
            {
                SortArray(arr);
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            int arrDim = 10;
            bool needSort = true;

            int[] array = GetArrayFromConsole(arrDim);

            Console.WriteLine();

            ShowArray(array, needSort);

        }


    }
}