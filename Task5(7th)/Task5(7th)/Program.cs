using System;

namespace Task5__7th_
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

                if (myArray[i] % 2 != 0)
                {
                    count++;
                }
            }


            Console.WriteLine($"Количество нечетных чисел {count}");
            Console.ReadKey();
        }
    }
}
