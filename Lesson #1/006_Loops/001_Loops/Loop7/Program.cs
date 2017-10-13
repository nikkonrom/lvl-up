using System;

// Циклическая конструкция - while. 

namespace Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Угадайте задуманный цвет с пяти попыток.");
            Console.WriteLine("Для выхода из программы введите - exit.");

            const int maxAttempt = 5; // Допустимое количество попыток.
            int attempt = 0;          // Счетчик попыток.
            string color = "red";     // Задуманный цвет.

            while (attempt < maxAttempt)
            {
                attempt++;
                Console.WriteLine("Попытка {0}:", attempt);
                
                string value = Console.ReadLine();

                if (value == "exit")
                {
                    break;
                }

                if (value != color)
                {
                    continue;
                }

                Console.WriteLine("Поздравляем, Вы угадали с {0} попытки!", attempt);
                break;
            }

            Console.WriteLine("Конец игры!");

            // Delay.
            Console.ReadKey();
        }
    }
}
