using System;

// Передача экземпляра класса в качестве аргумента метода

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Вызван метод класса MyClass");
        }
    }

    class MyClass2
    {
        // На 18 строке создаем метод с именем CallMethod, который принимает один аргумент типа MyClass и ничего не возвращает
        public void CallMethod(MyClass my)
        {
            // В теле метода CallMethod, на 21 строке вызываем метод с именем Method аргумента my 
            my.Method();
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            MyClass2 my2 = new MyClass2();

            my2.CallMethod(my);

            // Задержка
            Console.ReadKey();
        }
    }
}
