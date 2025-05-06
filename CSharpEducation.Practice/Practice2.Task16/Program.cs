using System;

class Program
{
    static void ChangeSign(ref int number)
    {

        number = -number;
    }

    static void Main()
    {
        int myNumber = 10;
        
        Console.WriteLine("Исходное значение: " + myNumber);
        
        ChangeSign(ref myNumber);
        
        Console.WriteLine("Измененное значение: " + myNumber);
    }
}