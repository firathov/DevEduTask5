using System;

namespace Task5__6th_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Запишите число массива {i}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nЧисло элементов в обратном направлении:");
            for (int j = myArray.Length; j > 0; j--)
            {
                Console.WriteLine($"\n{myArray[j - 1]}");
            }


            Console.ReadKey();
        }
    }
}