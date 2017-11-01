using System;

namespace Interfaces
{
    class DerivedClass : Interface1, Interface2
    {
        // На 10-й строке реализуем метод с именем Method из базового интерфейса Interface1 
        // При реализации метода используем технику явного указания имени интерфейса в имени
        // метода, которому принадлежит данный метод.

        // По умолчанию одноименные методы являются private, 
        // но явно указывать модификаторы доступа недопустимо.
        void Interface1.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Реализация метода Method() из Interface2");
        }
    }
}
