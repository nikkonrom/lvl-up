using System;

namespace Additiontask
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите слово про погоду на русском языке:");
            string word = Console.ReadLine();

            switch (word)
            {
                case "температура": Console.Write("temperature");
                    break;
                case "фаренгейт": Console.Write("Fahrenheit");
                    break;
                case "цельсий": Console.Write("Celsius");
                    break;
                case "облачно": Console.Write("cloudy");
                    break;
                case "солнечно": Console.Write("sunny");
                    break;
                case "дождь": Console.Write("rain");
                    break;
                case "ветренно": Console.Write("windy");
                    break;
                case "тепло": Console.Write("warmly");
                    break;
                case "холодно": Console.Write("coldly");
                    break;

                default:
                    Console.WriteLine("Такого слова нет в словаре!");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
