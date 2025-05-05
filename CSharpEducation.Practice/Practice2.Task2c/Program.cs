// See https://aka.ms/new-console-template for more information

Console.Write("Введите величину скорости км/час: ");
string skorost = Console.ReadLine();

if (double.TryParse(skorost, out double kilometerivchas))
{
    double metrivsekundu = kilometerivchas * 0.277778;
            
    Console.WriteLine($"{metrivsekundu}(м/с)");
}
