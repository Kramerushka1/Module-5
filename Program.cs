using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

namespace Module_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            (string Name, string Surname, int Age, string[] PetNames, string[] Favcolors) Anketa = UserInput();

            Console.WriteLine();
            ShowUserInput(Anketa);
        }

        //Метод для вывода данных на экран
        static void ShowUserInput((string Name, string Surname, int Age, string[] PetNames, string[] Favcolors) Anketa)
        {
            Console.WriteLine("Ваше имя: {0} \nВаша фамилия: {1} \nВаш возраст: {2}", Anketa.Name, Anketa.Surname, Anketa.Age);

            if(Anketa.PetNames.Length > 0)
            {
                Console.WriteLine("Ваших питомцев зовут:");
                foreach (string PetName in Anketa.PetNames)
                {
                    Console.WriteLine(PetName);
                }
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (string Favcolor in Anketa.Favcolors)
            {
                Console.WriteLine(Favcolor);
            }
        }

        //Метод для получения данных от пользователя
        static (string Name, string Surname, int Age, string[] PetNames, string[] Favcolors) UserInput()
        {
            (string Name, string Surname, int Age, string[] PetNames, string[] Favcolors) User;
            
            //Узнаем имя (User.Name)
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            //Узнаем фамилию (User.Surname)
            Console.WriteLine("Введите фамилию");
            User.Surname = Console.ReadLine();

            //Узнаем возраст (User.Age)
            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();
            } while (ValidInputCheck(age, out intage));

            User.Age = intage;

            //Узнаем наличие питомцев и их количество
            User.PetNames = Array.Empty<string>();

            Console.WriteLine("У вас есть питомцы?");
            string hasPet = Console.ReadLine();
            if (hasPet == "Да" || hasPet == "да")
            {
                string petCount;
                int intPetCount;
                do
                {
                    Console.WriteLine("Сколько у вас питомцев?");
                    petCount = Console.ReadLine();
                } while (ValidInputCheck(petCount, out intPetCount));

                //Заполняем массив petNames из метода
                User.PetNames = GetPetNames(intPetCount);
            }

            //Узнаем количество любимых цветов
            string colorsCount;
            int intcolorsCount;
            do
            {
                Console.WriteLine("Сколько у вас любимых цветов?");
                colorsCount = Console.ReadLine();
            } while (ValidInputCheck(colorsCount, out intcolorsCount));

            //Заполняем массив favcolors из метода
            User.Favcolors = GetFavColors(intcolorsCount);
        
            return User;
        }

        //Делаем проверку введеных данных через do while и TryParse
        static bool ValidInputCheck(string num, out int corrnumber)
        {
            if (int.TryParse(num, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                Console.WriteLine("Введите целое положительное число.");
                corrnumber = 0;
                return true;
            }
        }

        //Метод для заполнения массива с кличками питомцев petNames
        static string[] GetPetNames(int petCount)
        {
            string[] petNames = new string[petCount];

            for (int i = 0; i < petCount; i++)
            {
                Console.WriteLine("Введите кличку {0} питомца", i + 1);
                petNames[i] = Console.ReadLine();
            }
            return petNames;
        }

        //Метод для заполнения массива любимых цветов favcolors
        static string[] GetFavColors(int colorsCount)
        {
            string[] favColors = new string[colorsCount];

            for (int i = 0; i < colorsCount; i++)
            {
                Console.WriteLine("Введите любимый цвет {0}", i + 1);
                favColors[i] = Console.ReadLine();
            }
            return favColors;
        }
    }
}