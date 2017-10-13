using System;

// Оператор многозначного выбора - switch-case (переключатель). 

namespace Condition
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер дня недели: 1-2-3-4-5-6-7: ");
            
            string myDay = Console.ReadLine();

            // Конвертируем значение строковой переменной myDay в целочисленное значение
            // и записываем его в переменную с именем day типа int

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Понедельник.");
                    break;
                case 2:
                    Console.WriteLine("Вторник.");
                    break;
                case 3:
                    Console.WriteLine("Среда.");
                    break;
                case 4:
                    Console.WriteLine("Четверг.");
                    break;
                case 5:
                    Console.WriteLine("Пятница.");
                    break;
                case 6:
                    Console.WriteLine("Суббота.");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье.");
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
