namespace Module_5
{
    internal class Program
    {
        //Задание 5.2.8
        //Разделить метод из задания 5.1.6 GetArrayFromConsole() на два
        //Один метод GetArrayFromConsole() должен читать введенные с клавиатуры массивы и возвращать их
        //Второй метод SortArray() должен принимать параметром массив array типа данных int, сортировать его и возвращать.

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
        static int[] GetArrayFromConsole()
        {
            int[] result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] arr = GetArrayFromConsole();

            arr = SortArray(arr);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }


    }
}