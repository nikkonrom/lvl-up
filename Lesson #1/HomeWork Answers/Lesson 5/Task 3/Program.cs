using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            int salary = 2000;
            Console.Write("Введите выслугу лет: ");
            byte years = Convert.ToByte(Console.ReadLine());

            if ((years > 0) && (years < 5))
            {
                Console.WriteLine("Выслуга до 5 лет, премия составляет 10% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.1));
            }
            else if ((years >= 5) && (years < 10))
            {
                Console.WriteLine("Выслуга от 5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.15));
            }
            else if ((years >= 10) && (years < 15))
            {
                Console.WriteLine("Выслуга от 10 лет (включительно) до 15 лет, премия составляет 15% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.25));
            }
            else if ((years >= 15) && (years < 20))
            {
                Console.WriteLine("Выслуга от 15 лет (включительно) до 20 лет, премия составляет 15% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.35));
            }
            else if ((years >= 20) && (years < 25))
            {
                Console.WriteLine("Выслуга от 20 лет (включительно) до 25 лет, премия составляет 15% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.45));
            }
            else if (years >= 25)
            {
                Console.WriteLine("Выслуга от 25 лет (включительно) и более, премия составляет 15% от заработной платы {0} всего зарплата равна {1}", salary, salary + (salary * 0.5));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
