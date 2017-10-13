using System;

namespace Methods
{
    class Program
    {
        // Передается ссылка на исходные аргументы копия не создается.
        static void AddTwo(ref int a)
        {
            a = a + 2;
            Console.WriteLine("Значение int a = {0}", a);
        }

        static void Main()
        {
            Console.WriteLine("Введите число:");

            // Принимаем ввод от пользователя и преобразуем его в целочисленное значение
            
            string number = Console.ReadLine();
            int result = Int32.Parse(number);

            Console.WriteLine("Значение result = {0}", result);

            // В качестве аргумента передается сама переменная - result, а не её копия.
            AddTwo(ref result);
            Console.WriteLine("Значение result = {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
