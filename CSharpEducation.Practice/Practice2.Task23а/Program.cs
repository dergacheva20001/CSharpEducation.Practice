using System;

public class LeapYearChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите год:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int year))
        {
            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear)
            {
                Console.WriteLine($"{year} год - високосный.");
            }
            else
            {
                Console.WriteLine($"{year} год - не високосный.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
        }
    }
    static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        else if (year % 100 == 0)
        {
            return false;
        }
        else if (year % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}