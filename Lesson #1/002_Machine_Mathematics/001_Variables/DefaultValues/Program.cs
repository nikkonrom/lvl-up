using System;

namespace DefaultValues
{
    class Program
    {
        static void Main()
        {
            // На 11-й строке, создаем переменную с именем a, типа byte и не присваиваем ей никакого значения.

            byte a;         
            bool b;
            char c;
            string s;

            // На 18-й строке - ОШИБКА: Запрещается использование неинициализированной локальной переменной!

            //Console.WriteLine(a);

            // Задержка.
            Console.ReadKey();
        }
    }
}
