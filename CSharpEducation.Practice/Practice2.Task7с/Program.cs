// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите слово с маленькой буквы:");
string? inputWord = Console.ReadLine();

if (string.IsNullOrEmpty(inputWord))
{
    Console.WriteLine("Слово не должно быть пустым.");
    return;
}

string capitalizedWord = inputWord.Substring(0, 1).ToUpper() + inputWord.Substring(1).ToLower();

Console.WriteLine("Слово с заглавной буквы: " + capitalizedWord);