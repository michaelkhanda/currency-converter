using System;

namespace CurrencyConversion
{
    class Program
    {
        static double USD(double amountInKES)
        {
            double amountInUSD = amountInKES * 0.0090;
            return amountInUSD;
        }

        static double GBP(double amountInKES)
        {
            double amountInGBP = amountInKES * 0.0066;
            return amountInGBP;
        }
        static void Main(string[] args)
        {

            string answer ;
            string reset = "N";

            do
            {
                Console.WriteLine("What currency exchange would you like to undertake?\n1.KES to USD\n2.KES to GBP ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Enter the amount you wish to convert in KES ");
                        double amountInKES = double.Parse(Console.ReadLine());
                        double a = USD(amountInKES);
                        Console.WriteLine("Your amount in USD: " + "$" + a);
                        break;

                    case "2":
                        Console.WriteLine("Enter the amount you wish to convert in KES ");
                        double amountInKES = double.Parse(Console.ReadLine());
                        double b = GBP(amountInKES);
                        Console.WriteLine("Your amount GBP: " + "£" + b);
                        break;
                }
                Console.WriteLine("Do you wish to perform another transaction(Y/N)");
                reset = Console.ReadLine();

                Console.WriteLine("Thank you for choosing our bureau \nHave a nice day");
            }
            while (reset != "N");
            


        }
    }
}
