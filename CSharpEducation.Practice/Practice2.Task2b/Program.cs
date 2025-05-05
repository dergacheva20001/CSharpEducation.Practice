// See https://aka.ms/new-console-template for more information

Console.Write("Введите количество километров: ");
string input = Console.ReadLine();
        
if (int.TryParse(input, out int kilometers))
{
    int santimeters = kilometers * 100000;
    
    Console.WriteLine($"Сантиметры: {santimeters}");
}
