using System;

// Переменная (Variable) - это область памяти, которая хранит в себе некоторое значение, которое можно изменить.

namespace TypeBasics
{
    class Program
    {
        static void Main()
        {
            // На 13-й строке, создаем переменную с именем a, типа byte и присваиваем ей значение 2.
            
            byte a = 2;

            // На 17-й строке, выводим значение переменной - a, на экран.

            Console.WriteLine(a);

            // Задержка.
            Console.ReadKey();
        }
    }
}
