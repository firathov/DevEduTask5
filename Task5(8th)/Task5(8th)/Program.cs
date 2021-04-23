using System;

namespace Task5__8nd_
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

            Console.WriteLine();
            int[] myArray2 = new int[n];

            int count = 0;

            if (myArray.Length % 2 == 0)
            {
                count = myArray.Length / 2;
            }
            else
            {
                count = (myArray.Length) / 2 + 1;
            }

            int j = 0;

            for (int i = count; i < myArray2.Length; i++)
            {
                myArray2[j] = myArray[i];
                j++;
            }

            if (myArray.Length % 2 == 0)
            {
                j = myArray.Length / 2;
            }
            else
            {
                j = (myArray.Length) / 2;
                myArray2[j] = myArray[j];
                j++;
            }

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                myArray2[j] = myArray[i];
                j++;
            }

            foreach (int result in myArray2)
            {
                Console.WriteLine(result);
            }



            Console.ReadKey();
        }
    }
}