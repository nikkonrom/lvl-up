using System;

// Побитовые логические операции. (^)

// Например: 
// Используя операцию XOR, мы можем зашифровать сообщение.
// В таком виде шифрования используется один ключ, как для шифрования, так и для расшифровки.
// Криптостойкость такого ключа, можно увеличить, если увеличить его длину.

namespace Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort secretKey = 0x0088; // Секретный ключ (длина - 16 bit).
            char character = 'A';      // Исходный символ для шифрования.

            Console.WriteLine("Исходный символ: {0}, его код в кодовой таблице: {1:X}", character, (byte)character);
            Console.WriteLine("Размер символа: {0} = {1} бит", character, sizeof(char) * 8);

            // Зашифровываем символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Зашифрованный символ: {0}, его код в кодовой таблице: {1:X}", character, (byte)character);

            // Расшифровываем символ.
            character = (char)(character ^ secretKey);
            Console.WriteLine("Расшифрованный символ: {0}, его код в кодовой таблице: {1:X}", character, (byte)character);

            // Delay.
            Console.ReadKey();
        }
    }
}
