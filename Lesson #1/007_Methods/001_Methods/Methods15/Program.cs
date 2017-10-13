﻿using System;

namespace Methods
{
    class Program
    {
        static void Add(ref int x, ref int y, out int sum)
        {
            sum = x + y;
        }

        static void Main()
        {
            Console.WriteLine("Введите 1-e число.");
            
            string operand1 = Console.ReadLine();
            int summand1 = Int32.Parse(operand1);

            Console.WriteLine("Введите 2-e число.");
           
            string operand2 = Console.ReadLine();
            int summand2 = Int32.Parse(operand2);
                       
            int sum;

            Add(ref summand1, ref summand2, out sum);

            Console.WriteLine("{0} + {1} = {2}", summand1, summand2, sum);

            // Delay.
            Console.ReadKey();
        }
    }
}
