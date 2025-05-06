// See https://aka.ms/new-console-template for more information

string n = "";
string word;

do
{
    Console.Write("Введите слова , чтобы закончить ввод используйте слово 'стоп' для завершения: ");
    word = Console.ReadLine(); 
            
    if (word.ToLower() != "стоп" && word.Length > 0)
    {
        n += word + " ";
    }
} 
while (word.ToLower() != "стоп");
        
Console.WriteLine("Ваша фраза: " + n);