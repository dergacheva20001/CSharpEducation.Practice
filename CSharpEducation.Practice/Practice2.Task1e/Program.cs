// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите слова, чтобы закончить ввод используйте пустую строку для завершения):");

string n = "";
string word;

while (!string.IsNullOrEmpty(word = Console.ReadLine()))
{
    if (n == "")
    {
        n = word; 
    }
    else
    {
        n = n + " " + word; 
    }
    Console.Write("Введите слово: ");
}

Console.WriteLine("Ваша фраза: " + n);