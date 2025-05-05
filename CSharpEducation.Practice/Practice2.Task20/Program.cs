using System;

class Program
{
    static void Main()
    {

        Random random = new Random();


        int rows = 5; 
        int cols = 10; 


        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 101); 
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nРазница между максимальным и минимальным значениями в каждой строке:");
        for (int i = 0; i < rows; i++)
        {
            int min = array[i, 0];
            int max = array[i, 0];


            for (int j = 1; j < cols; j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }

            int difference = max - min;

            Console.WriteLine($"Строка {i + 1}: Разница = {difference} (Макс = {max}, Мин = {min})");
        }
    }
}