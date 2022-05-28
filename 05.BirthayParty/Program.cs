using System;

namespace _05.BirthayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int exHourToMin = examHour * 60 + examMinutes;
            int arHourToMin = arriveHour * 60 + arriveMinutes;

            int diffTimeInMin = 0;
            int totalHour = 0;
            int totalMin = 0;

            if (exHourToMin >= arHourToMin)
            {
                diffTimeInMin = exHourToMin - arHourToMin;
                if (diffTimeInMin >= 60)
                {
                    totalHour = diffTimeInMin / 60;
                    totalMin = diffTimeInMin % 60;
                }
                else
                {
                    totalMin = diffTimeInMin;
                }
            }
            else
            {
                diffTimeInMin = arHourToMin - exHourToMin;
                if (diffTimeInMin >= 60)
                {
                    totalHour = diffTimeInMin / 60;
                    totalMin = diffTimeInMin % 60;
                }
                else
                {
                    totalMin = diffTimeInMin;
                }
            }
            if ((exHourToMin - arHourToMin) > 30 && (exHourToMin - arHourToMin) < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{totalMin:d2} minutes before the start");
            }
            else if ((exHourToMin - arHourToMin) >= 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{totalHour}:{totalMin:d2} hours before the start");
            }
            else if (exHourToMin == arHourToMin)
            {
                Console.WriteLine("On time");
            }
            else if ((exHourToMin - arHourToMin) <= 30 && (exHourToMin - arHourToMin) > 0)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{totalMin} minutes before the start");
            }
            else if ((arHourToMin - exHourToMin) <= 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{totalMin:d2} minutes after the start");
            }
            else if ((arHourToMin - exHourToMin) >= 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{totalHour}:{totalMin:d2} hours after the start");
            }
        }
    }
}
