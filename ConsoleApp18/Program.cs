using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1./show-recent-currency-rates");
            Console.WriteLine("2./find-currency-rate-by-code");
            Console.WriteLine("3./calculate-amount-by-currecy");
            Console.WriteLine("4./exit");





            //USD, RUB, TRY

            string[] array = { "USD", "RUB", "TRY","a" };
            double[] array1 = { 1.70, 2,3,7 };

            double amount = Convert.ToDouble(Console.ReadLine());
            bool notFound = true;

            if (amount == 1)
            {
                for (int i = 0; i < array.Length && i < array1.Length; i++)
                {
                    Console.Write($"{array[i]}:");
                    Console.WriteLine(array1[i]);
                }


            }

            else if (amount == 2)
            {
                Console.WriteLine("Which currency do you want to see");
                string currency = Console.ReadLine();



                for (int i = 0; i < array1.Length; i++)
                {

                    if (currency == array[i])
                    {
                        Console.WriteLine(array1[i]);
                        notFound = false;
                    }
                }

                if (notFound)
                {
                    Console.WriteLine("Tapilmadi");
                }

            }

            else if (amount == 3)
            {
                Console.WriteLine("Meblegi daxil edin");
                double mebleg = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Valyutbi secin");
                string mvalyuta = Console.ReadLine();
                
                for (int i = 0; i < array1.Length; i++)
                {

                    if (mvalyuta == array[i])
                    {
                        //double 


                        double netice = mebleg / array1[i];
                        Console.Write(netice);
                        
                        Console.WriteLine("azn");
                       
                        
                        notFound = false;
                    }

                }
                if (notFound)
                {
                    Console.WriteLine("Tapilmadiiiii");
                }

            }
            else if (amount == 4)
            {
                Console.WriteLine("Stop");
            }
            Console.ReadLine();
        }
    }
}
