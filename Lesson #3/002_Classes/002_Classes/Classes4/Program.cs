using System;

// readonly - поля только для чтения.

namespace Classes
{
    class Program
    {
        // Поле только для чтения (устанавливается только конструктором)!
        public readonly string field = "hello";

        // Конструктор.
        public Program()
        {
            field = "Поле только для чтения ";

            field += "!";
        }

        static void Main()
        {
            Program program = new Program();

            Console.WriteLine(program.field);

            // Ошибка Компиляции.
            //program.field = "Попытка записи в поле только для чтения.";

            // Delay.
            Console.ReadKey();
        }
    }
}
