using System;

namespace Menu
{
    static class Add
    {
        public static void Show()
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {a + b}");
        }
    }
}