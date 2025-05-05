// See https://aka.ms/new-console-template for more information

Console.WriteLine("Сколько слов вы хотите ввести?");
int num = int.Parse(Console.ReadLine());

string n = "";

Console.WriteLine("Введите слова:");
for (int i = 0; i < num; i++)
{
    Console.Write($"Слово {i + 1}: ");
    string word = Console.ReadLine();
    
    if (i == 0)
    {
        n += word; 
    }
    else
    {
        n += " " + word; 
    }
}

Console.WriteLine("Ваша фраза: " + n);