using System;

namespace Classes
{
    // Вторая часть класса.
    partial class PartialClass
    {
        // Определение частичного метода. 
        partial void PartialMethod()
        {
            Console.WriteLine("Вызван частичный метод - PartialMethod()");
        }

        // Вызов частичного метода через метод обертку.
        public void CallPartialMethod()
        {
            PartialMethod();

            // При вызове нереализованного частичного метода, компилятор его проигнорирует 
            // и ошибки уровня выполнения не будет. См. 26 строку.
            MyMethod();
        }

        #region Реализация частичных методов в других частях класса необязательна!

        //partial void MyMethod()
        //{
        //    Console.WriteLine("Реализация частичных методов в других частях класса PartialClass - необязательна!"); ;
        //}
        
        #endregion

    }
}
