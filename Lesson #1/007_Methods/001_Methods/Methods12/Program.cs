using System;

namespace Methods
{
    class Program
    {
        // Параметр, передаваемый по значению, уничтожается при возврате значения методом
        static void AddTwo(int a)
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

            // В качестве аргумента передается не сама переменная - result, а её копия.
            AddTwo(result);
            Console.WriteLine("Значение result = {0}", result); 

            // Delay.
            Console.ReadKey();
        }
    }
}
