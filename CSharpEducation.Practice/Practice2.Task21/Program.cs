using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberToGuess = random.Next(1, 101);

            int userGuess = 0;
            
            int attempts = 0;


            Console.WriteLine("Добро пожаловать в игру Угадай число!");
            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");


            while (userGuess != numberToGuess)
            {
                Console.Write("Введите ваше число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {

                    attempts++;

                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {

                        Console.WriteLine($"Поздравляю! Вы угадали число {numberToGuess} за {attempts} попыток.");
                    }
                }
                else
                {

                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
            
            Console.WriteLine("Спасибо за игру! Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}