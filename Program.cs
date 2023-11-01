namespace Module_5
{
    internal class Program
    {
        //Задание 5.2.2 - 5.2.3
        //Добавьте код из юнита 4.4 (Задание 4.4.2), который получает данные пользователя
        //Исправьте метод ShowColor, ему необходимо передать поле name кортежа.

        
        static string ShowColor(string name)
        {
            Console.WriteLine($"{name}, напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    return color;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    return color;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    return color;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    return color;
            }
        }
        public static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine();

            string[] favColors = new string[3];
            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor(anketa.name);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ваши любимые цвета: ");
            foreach (string favColor in favColors)
            {
                Console.WriteLine(favColor);
            }

            Console.ReadKey();

        }
    }
}