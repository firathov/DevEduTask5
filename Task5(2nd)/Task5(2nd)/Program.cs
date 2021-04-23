using System;

namespace Task5__2nd_
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

            int maxNum = myArray[n - 1];
            int k = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNum)
                {
                    maxNum = myArray[i];
                    k = i;
                }
            }
            Console.WriteLine($"Максимальное число массива {k}");
            Console.ReadKey();
        }
    }
}

