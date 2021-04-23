using System;

namespace Task5_9th_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вводите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Вводите число массива{i}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int changer;
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        changer = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = changer;
                    }
                }
            }

            Console.WriteLine("\nПолучится следующим способом:");
            foreach (int order in array)

            Console.Write($"{order}");

            Console.Read();
        }
    }
}
