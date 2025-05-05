// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите строку:");
string inputString = Console.ReadLine();

Console.WriteLine("Введите символ для поиска:");
char targetChar = Console.ReadKey().KeyChar; 
Console.WriteLine(); 

if (string.IsNullOrEmpty(inputString))
{
    Console.WriteLine("Строка не должна быть пустой.");
    return;
}

double charCount = 0;
foreach (char c in inputString)
{
    if (char.ToLower(c) == char.ToLower(targetChar)) 
    {
        charCount++;
    }
}

double percentage = (charCount / inputString.Length) * 100;

Console.WriteLine($"Процент вхождения символа '{targetChar}' в строку: {percentage:F2}%");