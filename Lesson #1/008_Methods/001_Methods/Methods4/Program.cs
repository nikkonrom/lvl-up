using System;

// Методы с опциональными параметрами. 

namespace Methods
{
    class Program
    {        
        // Метод вызывается так же, если бы это были перегрузки.
        static void Operation(string value1 = "val", int value2 = 10, double value3 = 12.2)
        {
            Console.WriteLine("{0}, {1}, {2}", value1, value2, value3);
        }

        static void Main()
        {
            Operation();                  // 1-я перегрузка.
            Operation("val");             // 2-я перегрузка.
            Operation("val", 10);         // 3-я перегрузка. 
            Operation("val", 10, 12.2);   // 4-я перегрузка.


            // Нельзя поставить третий параметр value3 = 12.2, вместо второго параметра value2 = 10!
            // 12.2 не может быть приведено к int — здесь C# пытается оставить по умолчанию третий параметр, а не второй.
            //Operation("val", 12.2); // ОШИБКА!

            // В данном случае возможно использование именованных параметров.
            // Они состоят из указания имени параметра, двоеточия и значения, которое мы передаем.
           
            Operation("val", value3: 12.2);
            Operation(value2: 33, value3: 12.2);


            // Delay.
            Console.ReadKey();
        }
    }
}
