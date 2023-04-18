using ConsoleApp1;
using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Меню выбора:");
            Console.WriteLine("1. Ввести А");
            Console.WriteLine("2. Ввести В");
            Console.WriteLine("3. Выполнить операцию '+'");
            Console.WriteLine("4. Выполнить операцию '-'");
            Console.WriteLine("5. Выполнить операцию '*'");
            Console.WriteLine("6. Выполнить операцию '/'");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new EnterA().Run();
                    break;
                case 2:
                    new EnterB().Run();
                    break;
                case 3:
                    new Add().Run();
                    break;
                case 4:
                    new Subtract().Run();
                    break;
                case 5:
                    new Multiply().Run();
                    break;
                case 6:
                    new Divide().Run();
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный выбор.");
                    break;
            }
        }
    }
}
