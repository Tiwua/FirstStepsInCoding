using System;

namespace Converter_USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value in USD: ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.Write("The value in BGN is: ");
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}