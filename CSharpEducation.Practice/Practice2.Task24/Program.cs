using System;

namespace DaysOfWeekExample
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Дни недели:");
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))

                Console.WriteLine(day);
            }
        }
    }