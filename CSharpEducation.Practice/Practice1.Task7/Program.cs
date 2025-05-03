// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        double cA = 6.3;
        double c = 17;
        double cB = Math.Sqrt(c * c - cA * cA);
        Console.WriteLine("Исходные данные:");
        Console.WriteLine("Катет a = " + cA);
        Console.WriteLine("Гипотенуза с = " + c);
        Console.WriteLine("Катет b = " + cB);
    }
}