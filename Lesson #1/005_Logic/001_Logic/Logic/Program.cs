using System;

// Побитовые логические операции.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            byte operand1 = 0, operand2 = 0;
            int result;

            #region Конъюнкция

            // Таблица истинности для операций Конъюнкции (И) - & - [AND]  

            // Если хоть один из операндов имеет значение 0 - вся конструкция имеет значение 0. Иначе - 1 

            //    0 & 0 = 0         1 & 0 = 0
            //    0 & 1 = 0         1 & 1 = 1

            operand1 = 0xFF;                         // [1111 1111 Bin] = [FF Hex] = [255 Dec]            
            operand2 = 0x01;                         // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 & operand2;            // [0000 0001 Bin] = [01 Hex] = [01 Dec]

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Дизъюнкция

            // Таблица истинности для Дизъюнкции (ИЛИ) - | - [OR] 

            // Если хоть один из операндов имеет значение 1 - вся конструкция имеет значение 1. Иначе - 0

            //    0 | 0 = 0         1 | 0 = 1
            //    0 | 1 = 1         1 | 1 = 1

            operand1 = 0x02;                          // [0000 0010 Bin] = [02 Hex] = [02 Dec]            
            operand2 = 0x01;                          // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 | operand2;             // [0000 0011 Bin] = [03 Hex] = [03 Dec]

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Исключающее ИЛИ

            // Таблица истинности для Исключающего ИЛИ - ^ - [XOR]

            // Если операнды имеют одинаковое значение - результат операции 0, 
            // Если операнды разные - 1

            //    0 ^ 0 = 0         1 ^ 0 = 1
            //    1 ^ 1 = 0         0 ^ 1 = 1  

            operand1 = 0x03;                          // [0000 0011 Bin] = [03 Hex] = [03 Dec]            
            operand2 = 0x01;                          // [0000 0001 Bin] = [01 Hex] = [01 Dec]
            result = operand1 ^ operand2;             // [0000 0010 Bin] = [02 Hex] = [02 Dec]

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);

            #endregion
           
            #region Отрицание

            // Таблица истинности для Отрицания (НЕТ) - ~ - [NOT]

            // ~ 0  = 1                                // [0000 0001] = [01 Dec]
            // ~ 1  = 0                                // [1111 1110] = [-2 Dec]    

            operand1 = 0x01;
            result = ~operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion
           
            #region Изменение знака числа

            // Формула изменения знака числа, с (+N) на (-N) или наоборот.

            // Для того, чтобы сменить знак числа, необходимо:
            // выполнить его отрицание, а результат увеличить на 1.

            //  ~  +N + 1 = -N
            //  ~  -N + 1 = +N                      

            operand1 = 0x01;                            // [0000 0001]
            result = ~operand1;                         // [1111 1110]
            result++;                                   // [1111 1111]

            Console.WriteLine(" ~ {0} + 1 = {1} ", operand1, result);
            
            #endregion

            // Delay.
            Console.ReadKey();
        }
    }
}
