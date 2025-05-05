using System;

public class GuessTheNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101); 
        int guess = 0;         
        int attempts = 0;       
        int maxAttempts = 10;    
        bool hasGuessed = false;  

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine($"Я загадал число от 1 до 100. У вас есть {maxAttempts} попыток.");

        while (attempts < maxAttempts)
        {
            attempts++;

            Console.Write($"Попытка {attempts}: Введите ваше предположение: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out guess)) 
            {
                if (guess == secretNumber)
                {
                    hasGuessed = true;
                    break; 
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
            }
        }
        if (hasGuessed)
        {
            Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
        }
        else
        {
            Console.WriteLine($"Вы исчерпали все {maxAttempts} попыток. Вы проиграли.");
            Console.WriteLine($"Загаданное число было {secretNumber}.");
        }

        Console.WriteLine("Спасибо за игру!");
    }
}