using System;

public class GuessTheNumber
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Добро пожаловать в игру 'Угадай число'!");
        Console.WriteLine("Я загадал число от 1 до 100.");

        while (guess != secretNumber)
        {
            attempts++;

            Console.Write($"Попытка {attempts}: Введите ваше предположение: ");

            string input = Console.ReadLine();
            if (int.TryParse(input, out guess))
            {
                if (guess > secretNumber)
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                guess = -1; // Чтобы цикл продолжался
            }
        }

        Console.WriteLine("Спасибо за игру!");
    }
}