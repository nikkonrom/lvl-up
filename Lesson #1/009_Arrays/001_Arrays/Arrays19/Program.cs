using System;

// Массивы в C# - ковариантны, а не контрвариантны.

namespace Arrays
{
    public interface IAnimal
    {
        void Voice();
    }

    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Gav-Gav");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            IAnimal[] animal = dogs; // Ковариантность.

            //dogs = animal;  // Контрвариантность. - Ошибка.

            // Delay.
            Console.ReadKey();
        }
    }
}
