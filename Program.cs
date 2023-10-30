namespace Module_5
{
    internal class Program
    {
        //Задание 5.1.5
        //Напишите программу, которая:
        // - В цикле вызывает метод ShowColor()
        // - Записывает его значение в массив из трех цветов favcolors
        // - Отображает значения этого массива

        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
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
            string[] favColors = new string[3];
            for (int i = 0; i < favColors.Length; i++)
            {
                favColors[i] = ShowColor();
            }

            Console.WriteLine("Любимые цвета: ");
            foreach (string favColor in favColors)
            {
                Console.WriteLine(favColor);
            }

        }
    }
}