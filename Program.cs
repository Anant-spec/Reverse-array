using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "");
            }
            Array.Reverse(numbers);

            Console.WriteLine("\nReversed array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + "");
            }
        }
    }
}
