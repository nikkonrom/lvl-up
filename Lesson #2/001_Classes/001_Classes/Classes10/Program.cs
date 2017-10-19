using System;

// Автоматически реализуемые свойства (Auto-Implemented properties). 

// Автоматически реализуемые свойства это более лаконичная форма свойств, их есть смысл использовать,
// когда в методах доступа (get и set) не требуется дополнительная логика. 
// При создании автоматически реализуемых свойств, компилятор создаст закрытое, анонимное резервное поле, 
// которое будет доступно с помощью методов get и set свойства.

namespace Classes
{
    class Program
    {
        public class Author
        {
            // Автоматически реализуемые свойства. 
            public string Name { get; set; }
            public string Book { get; set; }
        }

        static void Main()
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Richter",            // Блок инициализатора.
                Book = "CLR via C#"
            };

            Author author2 = new Author        // ()
            {
                Name = "Steve McConnell",            // Блок инициализатора.
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            // Delay.
            Console.ReadKey();
        }
    }
}
