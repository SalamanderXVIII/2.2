using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.2. 2-й вариант, выскокий уровень, Гребенюк.
            Console.WriteLine("Введите двухзнчаное значение x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифру a: ");
            int a = int.Parse(Console.ReadLine());
            if (x / 10 == 5 || x % 10 == 5)
                Console.WriteLine("В числе " + x + " есть цифра 5");
            if (x / 10 == a || x % 10 == a)
                Console.WriteLine("В числе " + x + " есть цифра " + a);
        }
    }
}
