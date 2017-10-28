
// Наследование.

namespace Inheritance
{
    class BaseClass
    {
        public int baseNumber;

        // Конструктор по умолчанию.
        public BaseClass() 
        {
        }

        // Пользовательский конструктор.
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }
    }
}
