using System;

namespace Task5__5th_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[n];

            int count = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Запишите число массива {i}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
                if (i % 2 != 0)
                {
                    count += myArray[i];
                }
            }


            Console.WriteLine($"Сумма элементов с нечетными индексами {count}");
            Console.ReadKey();
        }
    }
}
