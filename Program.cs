using System;
using System.Drawing;
using System.Globalization;

namespace Module_5
{
    internal class Program
    {
        //Задание 5.5.8
        //Необходимо написать рекурсивный метод,
        //который возводит введенное число N типа int в указанную степень pow типа byte.

        public static void Main(string[] args)
        {
            int num1 = 5;
            byte num2 = 3;
            Console.WriteLine(PowerUp(num1, num2));
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {

                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}