using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1./show-recent-currency-rates");
                Console.WriteLine("2./find-currency-rate-by-code");
                Console.WriteLine("3./calculate-amount-by-currecy");
                Console.WriteLine("4./exit");

                string[] array = { "USD", "RUB", "TRY" };
                double[] array1 = { 1.70, 0.0271, 0.1031 };

                double amount = Convert.ToDouble(Console.ReadLine());
                bool notFound = true;     //teacher, burada bir neferden komek almisam. 

                if (amount == 1)
                {
                    for (int i = 0; i < array.Length && i < array1.Length; i++)
                    {
                        Console.Write($"{array[i]}: ");
                        Console.WriteLine($"{array1[i]} AZN");
                    }
                }

                else if (amount == 2)
                {
                    Console.WriteLine("Which currency do you want to see?");
                    string currency = Console.ReadLine();

                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (currency == array[i])
                        {
                            Console.WriteLine($"{array1[i]} AZN");
                            notFound = false;
                        }
                    }
                    if (notFound)
                    {
                        Console.WriteLine("Not found, please, try another currency.");
                    }
                }
                else if (amount == 3)
                {
                    Console.WriteLine("Enter the amount.");
                    double sum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Choose the currency what you want convert.");
                    string currency = Console.ReadLine();

                    for (int i = 0; i < array1.Length; i++)
                    {
                        if (currency == array[i])
                        {
                            double netice = sum / array1[i];
                            Console.Write($"Result: {netice}");
                            Console.WriteLine($" {array[i]}");
                            notFound = false;
                        }
                    }
                    if (notFound)
                    {
                        Console.WriteLine("Not found, please write the currency correctly.");
                    }
                }
                else if (amount == 4)
                {
                    Console.WriteLine("Program finished.");
                }
                Console.ReadLine();
            }
        }
    }
}
