using System;

// Перегрузка методов. 

namespace Methods
{
    class Program
    {
        // Перегруженные методы могут отличаться типом и количеством аргументов, а также ref и out параметрами.

        static void Function()                 // 1-я перегрузка.   
        {
            Console.WriteLine("Hello!");
        }

        static void Function(string s)         // 2-я перегрузка.
        {
            Console.WriteLine(s);
        }

        static void Function(int i)            // 3-я перегрузка.
        {
            Console.WriteLine(i);
        }

        static void Function(double d)         // 4-я перегрузка.
        {
            Console.WriteLine(d);
        }

        static void Function(string s, int i)  // 5-я перегрузка.
        {
            Console.WriteLine(s + i);
        }

        static void Function(int i, string s)  // 6-я перегрузка.
        {
            Console.WriteLine(i + s);
        }

        static void Function(ref int i, string s) // 7-я перегрузка.
        {
            Console.WriteLine(i + s);
        }

        // Перегруженные методы не могут отличаться возвращаемыми значениями!
        //static string Function(string s)     // 8-я перегрузка.              
        //{
        //    return s;
        //}

        // Перегруженные методы не могут отличаться друг от друга только параметрами ref и out!
        //static void Function(out int i, string s) 
        //{
        //    i = 5;
        //    Console.WriteLine(i + s);       // 9-я перегрузка.
        //}
         
        static void Main()
        {
            Function();                  // 1-я перегрузка.
            Function("A");               // 2-я перегрузка.
            Function(1);                 // 3-я перегрузка.
            Function(3.14);              // 4-я перегрузка.
            Function("B ", 2);           // 5-я перегрузка.
            Function(3, " C");           // 6-я перегрузка.

            int variable = 5;
            Function(ref variable, "D"); // 7-я перегрузка.

            // Delay.
            Console.ReadKey();
        }
    }
}
