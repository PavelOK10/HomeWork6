using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int ElementsCount = int.Parse(Console.ReadLine());
            int[] Array = new int[ElementsCount];
            int EvenNumbersSum = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом '{i}':\t");
                Array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ElementsCount; i++)
            {
                if (Array[i] % 2 == 0)
                    EvenNumbersSum += Array[i];
            }

            Console.WriteLine($"Сумма четных чисел в массиве: {EvenNumbersSum}");
        }
    }
}
