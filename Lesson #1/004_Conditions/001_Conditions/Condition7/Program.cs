using System;

// Тернарная условная операция.

namespace Condition
{
    class Program
    {
        static void Main()
        {
            string @string = "Hello ";

            Console.WriteLine("Введите свой логин:");

            // На 17 строке создаем переменную с именем login типа string и принимаем в нее ввод от пользователя
            
            string login = Console.ReadLine();

            // На 21 строке переменной @string присваиваем возвращаемое значение тернарного оператора
           
            @string += login == "Admin" ? "Administrator" : "User"; 

            Console.WriteLine(@string);

            // Delay.
            Console.ReadKey();
        }
    }
}
