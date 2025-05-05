// See https://aka.ms/new-console-template for more information

Console.Write("Введите количество метров: ");
string input = Console.ReadLine();
        
if (double.TryParse(input, out double meters))
{
    double kilometers = meters / 1000;
            
    Console.WriteLine($"{meters} метров равно {kilometers} километров.");
}

