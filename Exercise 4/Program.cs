using System;

namespace Exercise_4
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

            int MinValue = Array[0];

            for (int i = 1; i < Array.Length; i++)
            {
                if (MinValue > Array[i])
                {
                    MinValue = Array[i];
                }

            }

            Console.WriteLine($"Наименьшее число в данном массиве: {MinValue}");
        }
    }
}
