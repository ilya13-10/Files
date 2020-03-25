using System;
using System.IO;
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для регестрации нажмите 1, если у вас уже имеется аккаунт, нажите 2");
            double vibor = double.Parse(Console.ReadLine());
            if (vibor == 1)
            {
                Console.WriteLine("Введите имя: ");
                string Nazvanie = Console.ReadLine();
                File.Create("C:\\ПР_Раб\\" + Nazvanie + ".txt");
                Console.WriteLine("Введите Пароль: ");
                string user_password = Console.ReadLine();
                FileStream file_1 = new FileStream("C:" + Nazvanie + ".txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file_1);
                writer.WriteLine(user_password);
                writer.Close();
                Console.WriteLine("Регистрация завершена");
            }
            if (vibor == 2)
            {
                Console.Clear();
                Console.WriteLine("Введите имя: ");
                string Nazvanie = Console.ReadLine();
                FileStream file_2 = new FileStream("C:" + Nazvanie + ".txt", FileMode.Open);
                StreamReader reader = new StreamReader(file_2);
                string proverka = reader.ReadLine();
                reader.Close();
                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();
                if (proverka == password)
                {
                    Console.WriteLine("Вы авторизировались, добро пожаловать");
                }
                else Console.WriteLine("Ошибка");
            }
        }
    }
}
