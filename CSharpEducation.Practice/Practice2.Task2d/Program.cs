// See https://aka.ms/new-console-template for more information

Console.Write("Введите температуру (С°): ");
string temperatura = Console.ReadLine();

if (double.TryParse(temperatura, out double gradusiC))
{
    double gradusiF = (gradusiC*9/5) + 32;
            
    Console.WriteLine($"{gradusiF}(F°)");
}
