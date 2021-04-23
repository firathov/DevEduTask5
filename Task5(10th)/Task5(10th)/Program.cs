using System;

namespace Task5_10th_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Длина массива равна: 20");
            int n = 20;
            int[] myArray = new int[n];

            myArray[0] = 0;
            myArray[1] = 1;

            for (int i = 2; i < myArray.Length; i++)
            {
                myArray[i] = myArray[i - 1] + myArray[i - 2];
            }

            foreach (int text in myArray)
            {
                Console.WriteLine($"\n{text}");
            }
            Console.ReadKey();
        }
    }
}
