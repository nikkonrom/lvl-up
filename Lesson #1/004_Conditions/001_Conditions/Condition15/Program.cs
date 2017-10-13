using System;

// Оператор многозначного выбора - switch-case (переключатель). 

namespace Condition
{
    class Program
    {
        static void Main()
        {
            // Предлагаем пользователю выбрать напиток.
            Console.WriteLine("Размеры стаканчиков кофе: 1 = Маленький, 2 = Средний, 3 = Большой");
            Console.Write("Пожалуйста, сделайте свой выбор: ");

            // Принимаем ввод от пользователя.
            string coffeeSize = Console.ReadLine();

            int cost = 0;

            // Если оператор case имеет в своем теле код, то не поддерживается "проваливание".
            // Для организации "проваливания" можно использовать оператор безусловного перехода - goto
            switch (coffeeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Неверный выбор. Пожалуста выберите 1, 2, или 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Внесите {0} копеек.", cost);
                Console.WriteLine("Спасибо!");
            }
            else
            {
                Console.Write("Пожалуйста, повторите выбор.");
            }
            
            // Delay.
            Console.ReadKey();
        }
    }
}
