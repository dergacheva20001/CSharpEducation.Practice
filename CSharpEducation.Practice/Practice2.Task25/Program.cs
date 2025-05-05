using System;

namespace DaysOfWeekApp
{
    enum DayOfWeek
    {
        Monday = 1,   
        Tuesday = 2,    
        Wednesday = 3,   
        Thursday = 4,    
        Friday = 5,      
        Saturday = 6,    
        Sunday = 7       
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число от 1 до 7:");

            string input = Console.ReadLine();

            if (int.TryParse(input, out int dayNumber))
            {
                if (dayNumber >= 1 && dayNumber <= 7)
                {

                    DayOfWeek day = (DayOfWeek)dayNumber;

                    Console.WriteLine($"День недели: {day}");
                }
                else
                {
                    Console.WriteLine("Число должно быть от 1 до 7.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное число.");
            }
        }
    }
}