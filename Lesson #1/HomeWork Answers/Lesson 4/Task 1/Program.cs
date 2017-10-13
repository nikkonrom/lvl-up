using System;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            int operand1 = 10, operand2 = 4;
            Console.WriteLine("Введите знак арифметического действия:");
            string sing = Console.ReadLine();

            switch (sing)
            {
                case "+": Console.WriteLine("{0} + {1} = {2}", operand1, operand2, operand1 + operand2);
                    break;
                case "-": Console.WriteLine("{0} - {1} = {2}", operand1, operand2, operand1 - operand2);
                    break;
                case "*": Console.WriteLine("{0} * {1} = {2}", operand1, operand2, operand1 * operand2);
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        Console.WriteLine("{0} / {1} = {2}", operand1, operand2, operand1 / operand2);
                    }
                    else
                    {
                        Console.WriteLine("На 0 делить нельзя!");
                    }
                    break;

                default:
                    Console.WriteLine("Вы ввели знак не арифметической операции!");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
