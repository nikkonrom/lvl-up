using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 // Math.Sqrt() - математическая функция, которая извлекает квадратный корень

namespace MathSqrt
{
    class Program
    {
        static void Main()
        {
            double x = 256;

            double result = Math.Sqrt(x);  
    
            Console.Write("Квадратный корень равен: ");
            Console.WriteLine(result);
            
            // Delay.
            Console.ReadKey();
        }
    }
}
