// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        double cA = 6.5;
        double cB = 15;
        double c = Math.Sqrt(cA * cA + cB * cB);
        Console.WriteLine("Исходные данные:");
        Console.WriteLine("Катет a = " + cA);
        Console.WriteLine("Катет b = " + cB);
        Console.WriteLine("Гипотенуза c = " + c);
    }
}