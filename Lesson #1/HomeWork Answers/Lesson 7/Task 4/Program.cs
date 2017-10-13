using System;

namespace Task_4
{
    class Program
    {
        static void Otric(int operand)
        {
            operand = operand >> 31;

            if (operand == -1)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число положительное");
            }
        }

        static void Remainder(int operand)
        {

            if ((operand % 2) == 0 && (operand % 5) == 0 && (operand % 3) == 0 && (operand % 6) == 0 && (operand % 9) == 0)
            {
                Console.WriteLine("Число делиться без остатка на 2, 5, 3, 6, 9");
            }
            else
            {
                Console.WriteLine("Число не делиться без остатка на 2, 5, 3, 6, 9");
            }
        }

        static void Simple(int operand)
        {
            int divider;   // Делитель.
            int remainder; // Остаток от деления operand на divider.
            divider = 2;   // Сперва будем делить на два.

            do
            {
                remainder = operand % divider;

                if (remainder != 0)
                    divider++;
            }
            while (remainder != 0);

            if (divider == operand)
            {
                Console.WriteLine("{0} - простое число", operand);
            }
            else
            {
                Console.WriteLine("{0} - не простое число", operand);
            }
        }

        static void Main()
        {
            Console.Write("Введите число для проверки: ");
            int operand = Convert.ToInt32(Console.ReadLine());

            Simple(operand);
            Otric(operand);
            Remainder(operand);

            // Delay.
            Console.ReadKey();
        }
    }
}
