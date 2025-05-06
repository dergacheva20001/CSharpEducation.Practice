// See https://aka.ms/new-console-template for more information

{
    string inputString = "Пример строки для подсчета символов";
    char targetChar = 'о';
    
    int count = 0;
    foreach (char c in inputString)
    {
        if (c == targetChar)
        {
            count++;
        }
    }

    double percentage = (double)count / inputString.Length * 100;
    
    Console.WriteLine($"Символ '{targetChar}' встречается в строке {count} раз.");
    Console.WriteLine($"Процент вхождения символа '{targetChar}' в строку: {percentage:F2}%");
}