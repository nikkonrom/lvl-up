using System;

// Конструкторы.

// ВАЖНО: 
// Если вы создали пользовательский конструктор (принимающий аргументы),
// то конструктор по умолчанию, автоматически создаваться НЕ БУДЕТ, его придется создать явно.

namespace Classes
{
    class Program
    {
        static void Main()
        {
            // Применяем конструктор по умолчанию.  
            //Point pointA = new Point();                                              //  Снять 
            //Console.WriteLine("pointA.X = {0} pointA.Y = {1}", pointA.X, pointA.Y);  //  комментарий 

            Console.WriteLine(new string('-', 30));

            // Применяем конструктор с параметрами.
            Point pointB = new Point(100, 200);
            Console.WriteLine("pointB.X = {0} pointB.Y = {1}", pointB.X, pointB.Y);

            // Delay.
            Console.ReadKey();
        }
    }
}
