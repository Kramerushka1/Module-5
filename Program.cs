namespace Module_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //Создайте кортеж User, содержащий имя пользователя Name и массив с текстовой информацией о его пяти любимых блюдах Dishes.
            //Заполните имя пользователя через ввод в консоль, а информацию о блюдах — в цикле через консоль.
            (string Name, string[] FavoriteDishes) User;
            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();
            User.FavoriteDishes = new string[5];

            for (int i = 0; i < User.FavoriteDishes.GetLength(0); i++)
            {
                Console.Write("Введите любимое блюдо #{0}: ", i + 1);
                User.FavoriteDishes[i] = Console.ReadLine();
            }

        }
    }
}