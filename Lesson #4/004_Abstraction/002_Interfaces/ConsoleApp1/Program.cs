using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IGoEater
    {
        void Go();
        void Eat();
    }

    interface ISecurity
    {
        void Guard();
    }

    class  Dog : IGoEater, ISecurity
    {
        public void Go()
        {
            Console.WriteLine("Dog step");
        }

        public void Eat()
        {
            Console.WriteLine("Dog style eat");
        }

        public void Guard()
        {
            Console.WriteLine("Done.");
        }
    }

    class  Cat : IGoEater
    {
        public void Go()
        {
            Console.WriteLine("Cat step");
        }

        public void Eat()
        {
            Console.WriteLine("Cat style eat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            IGoEater animal = cat;
            animal = dog;
        }
    }
}
