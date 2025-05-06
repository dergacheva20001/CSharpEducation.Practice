using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine("До обмена:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);

     
        Swap(ref num1, ref num2);

     
        Console.WriteLine("После обмена:");
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
    }
}