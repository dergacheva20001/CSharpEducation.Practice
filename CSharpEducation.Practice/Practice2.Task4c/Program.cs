// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите высоту треугольника из символов: ");
int height = Convert.ToInt32(Console.ReadLine());
        
Console.WriteLine("Введите строку символов для отрисовки: ");
string symbol = Console.ReadLine();

for (int i = 1; i <= height; i++)
{
    for (int j = height - i; j > 0; j--)
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write(symbol);
    }

    Console.WriteLine();
}