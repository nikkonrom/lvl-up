using System;

namespace Addition_task_2
{
    class Program
    {
        static void Main()
        {
            bool A = true, B = false;

            Console.WriteLine("{0} || {1} = {2}", A, B, A || B);
            Console.WriteLine("!(!{0} && !{1}) = {2}", A, B, !(!A & !B));

            // Delay.
            Console.ReadKey();
        }
    }
}
