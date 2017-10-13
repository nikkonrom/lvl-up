using System;

// Упрощенный цикл Паук (Spider).  

namespace Loop
{
    class Program
    {
        static void Main()
        {
            char character = '\0';            

            for (; ; )
            {
                character = Console.ReadKey().KeyChar;

                switch (character)
                {
                    case 'l': // 'l' - охраняющее условие 1.
                        {
                            Console.WriteLine("Go left"); continue; // охраняемая команда.
                        }
                    case 'r': // 'r' - охраняющее условие 2.
                        {
                            Console.WriteLine("Go right"); continue; // охраняемая команда.
                        }
                }

                switch (character)
                {
                    case 'x': // 'x' - условие выхода 1.
                        {
                            Console.WriteLine("Exit"); break; // команда завершения.
                        }
                    case 'q': // 'q' - условие выхода 2.
                        {
                            Console.WriteLine("Quit"); break; // команда завершения.
                        }
                    default: // Ветвь альтернативного завершения.
                        {
                            Console.WriteLine("Alternative exit"); break;
                        }
                }
                                
                break;  // Прерывание цикла.
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
