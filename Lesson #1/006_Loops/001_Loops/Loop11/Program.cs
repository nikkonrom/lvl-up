using System;

// Циклическая конструкция - do-while. 

// Факториал числа n (обозначается n!, произносится - эн факториал) — это произведение всех натуральных чисел,
// от 1 до n включительно:
//     n! = 1 * 2 * 3 * ... * n
//     0! = 1

// В комбинаторике факториал натурального числа n интерпретируется как количество перестановок множества из n элементов. 
// Например, для множества {A,B,C,D} из 4-х элементов существует: 4! = 1 * 2 * 3 * 4 = 24 перестановки:

//     ABCD  BACD  CABD  DABC
//     ABDC  BADC  CADB  DACB
//     ACBD  BCAD  CBAD  DBAC
//     ACDB  BCDA  CBDA  DBCA
//     ADBC  BDAC  CDAB  DCAB
//     ADCB  BDCA  CDBA  DCBA

namespace Loop
{
    class Program
    {
        static void Main()
        {
            int counter = 4;
            int factorial = 1;

            Console.Write("Факториал числа: {0}! = ", counter);

            do
            {
                // Сначала умножение, потом декремент. 
                factorial *= counter--;
                
                // Данная строка эквивалентна:

                //factorial = factorial * counter;
                //counter = counter - 1;
            }
            while (counter > 0);

            Console.WriteLine("{0}", factorial);

            // Delay.
            Console.ReadKey();
        }
    }
}
