using System;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.2.14
        //Иcпользуйте методы из задания 5.2.8.
        //Модифицируйте метод GetArrayFromConsole так, чтобы размерность массива указывалась в качестве необязательного параметра num.
        //Значение по умолчанию оставить 5. 

        //Задание 5.2.15
        //Вызовите метод GetArrayFromConsole, не указывая необязательный параметр.
        //Результат работы метода должен быть в переменной array.
        //Передайте эту переменную в метод SortArray, а результат этого метода сохраните в переменной sortedarray.

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

        public static void Main(string[] args)
        {
            int arrayDim = 3;
            int[] array = GetArrayFromConsole(arrayDim);

            int[] sortedArray = SortArray(array);
            
            Console.WriteLine();

            foreach (int i in sortedArray)
            {
                Console.WriteLine(i);
            }

        }


    }
}