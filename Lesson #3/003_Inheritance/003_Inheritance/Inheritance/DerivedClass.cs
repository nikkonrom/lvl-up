
// Наследование.

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Конструктор.
        public DerivedClass()
        {
            // Изменяем все доступные поля унаследованные от базового класса.

            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";            
        }
    }
}
