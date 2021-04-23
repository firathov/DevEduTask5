using System;

namespace Task5__3nd_
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

            int minNum = myArray[0];
            int k = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minNum)
                {
                    minNum = myArray[i];
                    k = i;
                }
            }
            Console.WriteLine($"Индекс минимального элемента массива {k}");
            Console.ReadKey();
        }
    }
}
