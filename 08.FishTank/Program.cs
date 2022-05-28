using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double bitcoinInLev = 1168;
            const double chineseYuanInDolar = 0.15;
            const double dolarInLev = 1.76;
            const double euroInLev = 1.95;

            int bitcoinNumber = int.Parse(Console.ReadLine());
            double youanumber = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinSum = bitcoinInLev * bitcoinNumber;
            double youan = youanumber * chineseYuanInDolar;
            double youanInLev = youan * dolarInLev;
            double euro = (bitcoinSum + youanInLev) / euroInLev;
            comission /= 100.0;
            double finalSum = euro - euro * comission;

            Console.WriteLine($"{finalSum:F2}");


        }
    }
}


