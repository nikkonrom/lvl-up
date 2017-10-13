using System;

//Дано два числа A и B (A<B) выведите суму всех чисел расположенных между данными числами на экран. 
//Дано два числа A и B (A<B) выведите все нечетные значения, расположенные между данными числами. 

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите первое число:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            for (double i = x; x < y; x++)
            {
                if ((x % 2) != 0)
                {
                    Console.WriteLine("{0} ", x);
                }
                result += x;
            }

            Console.WriteLine("Сумма чисел равна {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
