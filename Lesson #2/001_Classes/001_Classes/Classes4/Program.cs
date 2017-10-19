using System;

// Классы. (Использование свойств, для доступа к закрытым полям.)

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                if (value == "Goodbye")
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку.");
                else
                    field = value;
            }

            get
            {
                if (field == null)
                    return "В поле field отсутствуют данные.";
                else if (field == "hello world")
                    return field.ToUpper() + "!";
                else
                    return field;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.Field = "Goodbye";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));

            instance.Field = "hello world";
            Console.WriteLine(instance.Field);

            // Delay.
            Console.ReadKey();
        }
    }
}
