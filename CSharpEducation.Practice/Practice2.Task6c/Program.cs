namespace Practice2.Task6c;

public abstract class CharacterFrequency
{
    public static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Использование: CharacterFrequency <строка> <символ>");
            return;
        }

        string inputString = args[0]; 
        char targetChar;
        
        if (!string.IsNullOrEmpty(args[1]))
        {
            targetChar = args[1][0];
        }
        else
        {
            Console.WriteLine("Символ для поиска не указан.");
            return;
        }
        
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

        if (inputString.Length > 0)
        {
            var percentage = (charCount / inputString.Length) * 100;

            Console.WriteLine($"Процент вхождения '{targetChar}' в '{inputString}': {percentage:F2}%");
        }
    }
}