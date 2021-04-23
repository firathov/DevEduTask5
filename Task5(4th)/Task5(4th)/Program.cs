using System;

namespace Task5__4nd_
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
                Console.WriteLine($"Запишите Элемент массива массива {i}");
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
            Console.WriteLine($"Индекс максимального элемента {k}");
            Console.ReadKey();
        }
    }
}