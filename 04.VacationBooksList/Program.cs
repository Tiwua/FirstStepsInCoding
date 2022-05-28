using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string moviePackage = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());

            double finalSum = 0;

            switch (movieName)
            {
                case "John Wick":
                    switch (moviePackage)
                    {
                        case "Drink":
                            finalSum = numberOfTickets * 12;
                            break;
                        case "Popcorn":
                            finalSum = numberOfTickets * 15;
                            break;
                                case "Menu":
                            finalSum = numberOfTickets * 19;
                            break;
                    }
                    break;
                case "Star Wars":
                    switch (moviePackage)
                    {
                        case "Drink":
                            finalSum = numberOfTickets * 18;
                            break;
                        case "Popcorn":
                            finalSum = numberOfTickets * 25;
                            break;
                        case "Menu":
                            finalSum = numberOfTickets * 30;
                            break;
                    }
                            if (numberOfTickets >= 4)
                            {
                                finalSum -= finalSum * 0.3;
                            }
                    break;
                case "Jumanji":
                    switch (moviePackage)
                    {
                        case "Drink":
                            finalSum = numberOfTickets * 9;
                            break;
                        case "Popcorn":
                            finalSum = numberOfTickets * 11;
                            break;
                        case "Menu":
                            finalSum = numberOfTickets * 14;
                            break;
                    }
                    if (numberOfTickets == 2)
                    {
                        finalSum -= finalSum * 0.15;
                    }
                    break;
            }
            Console.WriteLine($"Your bill is {finalSum:f2} leva.");



        }
    }
}
