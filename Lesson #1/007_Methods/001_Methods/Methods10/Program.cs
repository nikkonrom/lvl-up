using System;

// Методы с выходными параметрами (out).

namespace Methods
{
    class MyMathClass
    {
        static ulong power(uint x, uint n)
        {
            if (n == 0) return 1;
            for (; n > 1; n--)
                x *= x;
            return x;
        }
    }
}
