using System;

// Оператор многозначного выбора - switch-case (переключатель). Проваливание.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер дня недели: 1-2-3-4-5-6-7: ");
            
            string day = Console.ReadLine();

            switch (day)
            {
                // Для пустых операторов case разрешено "проваливание" от одного оператора к другому. 
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Этот день недели - Рабочий.");
                    break;
                case "6":
                case "7":
                    Console.WriteLine("Этот день недели - Выходной.");
                    break;

                default:
                    Console.WriteLine("Вы ввели несуществующий день недели.");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
