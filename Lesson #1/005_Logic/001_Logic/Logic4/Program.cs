using System;

// Логические операции.

namespace Logic
{
    class Program
    {
        static void Main()
        {
            bool operand1 = false, operand2 = false, result = false;

            #region Конъюнкция

            // Таблица истинности для Конъюнкции (И) - && - [AND]

            // Если хоть одно из выражений операции операции конъюнкции имеет значение false -
            // все выражение имеет значение false, иначе - true

            // false && false = false                  true && false = false
            // false && true = false                   true && true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 && operand2;             // false

            Console.WriteLine("{0} AND {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Дизъюнкция

            // Таблица истинности для Дизъюнкции (ИЛИ) - || - [OR]

            // Если хоть одно из выражений операции операции Дизъюнкции имеет значение true -
            // все выражение имеет значение true, иначе - false

            // false || false = false                  true || false = true         
            // false || true = true                    true || true = true

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 || operand2;             // true

            Console.WriteLine("{0} OR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Исключающее ИЛИ

            // Таблица истинности для Исключающего ИЛИ - ^ - [XOR]

            // Если оба выражения операции Исключающего ИЛИ имеют одинакое значение -
            // все выражение имеет значение false, если разные - true 


            // false ^ false = false                   true ^ false = true
            // false ^ true = true                     true ^ true = false

            operand1 = true;                           // true          
            operand2 = false;                          // false
            result = operand1 ^ operand2;              // true

            Console.WriteLine("{0} XOR {1} = {2}", operand1, operand2, result);
            
            #endregion

            #region Отрицание

            // Таблица истинности для Отрицания (НЕТ) - ! - [NOT]

            // !false  = true
            // !true  = false       

            operand1 = true;
            result = !operand1;

            Console.WriteLine("NOT {0} = {1}", operand1, result);
            
            #endregion
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
