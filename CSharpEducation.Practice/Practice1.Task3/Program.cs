// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет, как тебя зовут?");
        string name = Console.ReadLine();
        Console.WriteLine("Привет, " + name + "!");
    }
}