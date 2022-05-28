using System;

namespace _03.DepositCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double saveMoney = 0;
                while (saveMoney < budget)
                {
                    saveMoney += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }

        }
    }
}
