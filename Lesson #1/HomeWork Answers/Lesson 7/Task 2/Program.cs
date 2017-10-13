using System;

namespace Task_2
{
    class Program
    {
        static int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        static int Sub(int operand1, int operand2)
        {
            return operand1 - operand2;
        }

        static int Mul(int operand1, int operand2)
        {
            return operand1 * operand2;
        }

        static int Div(int operand1, int operand2)
        {
            if (operand2 != 0)
            {
                return operand1 / operand2;
            }
            else
            {
                Console.WriteLine("Деление на 0");
                return 0;
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите 1 число:");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2 число:");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции: + - * /");
            string sing = Console.ReadLine();

            switch (sing)
            {
                case "+": Console.WriteLine("Сложение {0}", Add(operand1, operand2));
                    break;
                case "-": Console.WriteLine("Вычитание {0}", Sub(operand1, operand2));
                    break;
                case "*": Console.WriteLine("Умножение {0}", Mul(operand1, operand2));
                    break;
                case "/": Console.WriteLine("Деление {0}", Div(operand1, operand2));
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный знак");
                    break;
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
