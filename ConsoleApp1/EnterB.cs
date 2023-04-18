using System;

namespace Menu
{
    public class EnterB
    {
        public void Run()
        {
            Console.WriteLine("Введите значение В:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + b);
        }
    }
}
