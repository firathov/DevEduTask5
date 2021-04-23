using System;

namespace Task5_11th_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1;
            double word1;

            string name2;
            double word2;

            int age1;
            int age2;
            

            bool result = false;

            Console.Write("Введите имя первого человека:\t");
            do
            {
                name1 = Console.ReadLine();
                bool result1 = Double.TryParse(name1, out word1);
                if (result1 == false)
                {
                    Console.Write("Введите имя второго человека:\t");
                    result = true;

                }
                else
                {
                    Console.Write("Имя человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);

            do
            {
                name2 = Console.ReadLine();
                bool result2 = double.TryParse(name2, out word2);
                if (result2 == false)
                {
                    Console.Write("Введите возраст первого человека:\t");
                    result = true;
                }
                else
                {
                    Console.Write("Имя человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);
            age1 = Convert.ToInt32(null);
            do
            {
                try
                {
                    age1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите возраст второго человека:\t");
                    result = true;
                }
                
                catch
                {
                    Console.Write("Возраст человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }

            while (result == false);
            age2 = Convert.ToInt32(null); //не смог вывести из массива, пришлось сделать так (закройте глаза плз) :(
            do
            {
                try
                {
                    age2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Возраст человека не может быть введён другими символами, попробуйте ещё:\t");
                    result = false;
                }
            }
            while (result == false);


            Console.WriteLine($"А человек с каким именем старше? (Если {name1} нажмите 1, если {name2} 2)");

            bool anotherNum = true;
            do
            {
                string comp = Console.ReadLine();
                switch (comp)
                {
                    case "1":

                        if (age1 > age2)
                        {
                            Console.WriteLine($"Правильно {name1} старше {name2} на {age1 - age2} лет");
                        }
                        else if (age1 == age2)
                        {
                            Console.WriteLine($"Не правильно {name1} и {name2} ровесники");
                        }
                        else if (age1 < age2)
                        {
                            Console.WriteLine($"Не правильно, {name2} старше {name1} на {age2 - age1} лет");
                        }
                        break;

                    case "2":
                        if (age2 > age1)
                        {
                            Console.WriteLine($"Правильно {name2} старше {name1} на {age2 - age1} лет");
                        }
                        else if (age2 == age1)
                        {
                            Console.WriteLine($"Не правильно {name2} и {name1} ровесники");
                        }
                        else if (age2 < age1)
                        {
                            Console.WriteLine($"Не правильно, {name1} старше {name2} на {age1 - age2} лет");
                        }
                        break;

                    default:
                        Console.WriteLine("Ответ не корректен, попробуйте ещё раз");
                        anotherNum = false;
                        break;
                }
            }
            while (anotherNum == false);
            
                Console.ReadKey();

              
        }
    }
}
