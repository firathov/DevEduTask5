using System;

namespace Task4_1st_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Вводите длину массива");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Вводите число массива{i + 1}");
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int minNum = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minNum)
                {
                    minNum = myArray[i];
                }
            }
            Console.WriteLine($"Минимальное число {minNum}");
            Console.ReadKey();


        }
    }
}