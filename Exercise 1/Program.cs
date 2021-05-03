using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int ElementsCount = int.Parse(Console.ReadLine());
            int[] Array = new int[ElementsCount];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом '{i}':\t");
                Array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива:");

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }
}
