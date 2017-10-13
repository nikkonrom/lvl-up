using System;

namespace Arrays
{
    class Program
    {
        static int[] ModifyArray(int[] array, int modifier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * modifier;
            }

            return array;
        }

        static void Main()
        {

            int[] myArray = { 1, 2, 3, 4, 5 };

            myArray = ModifyArray(myArray, 5);

           
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("{0},",myArray[i]);
            }

           
            Console.ReadKey();
        }
    }
}
