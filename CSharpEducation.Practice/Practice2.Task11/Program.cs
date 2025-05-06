using System;

namespace ArrayFiller
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 2)
            {
                Console.WriteLine("Пожалуйста, передайте два аргумента: размер массива и число для заполнения.");
                return;
            }

            if (!int.TryParse(args[0], out int arraySize) || arraySize <= 0)
            {
                Console.WriteLine("Первый аргумент должен быть положительным целым числом.");
                return;
            }

            if (!int.TryParse(args[1], out int fillNumber))
            {
                Console.WriteLine("Второй аргумент должен быть целым числом.");
                return;
            }

            int[] array = new int[arraySize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = fillNumber;
            }

            Console.WriteLine("Созданный массив:");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}