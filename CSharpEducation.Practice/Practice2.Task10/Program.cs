using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Пожалуйста, передайте размер массива в качестве аргумента командной строки.");
                return;
            }

            if (!int.TryParse(args[0], out int arraySize) || arraySize <= 0)
            {
                Console.WriteLine("Пожалуйста, передайте корректный положительный размер массива.");
                return;
            }

            int[] array = new int[arraySize];


            for (int i = 0; i < arraySize; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine("Созданный массив:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}