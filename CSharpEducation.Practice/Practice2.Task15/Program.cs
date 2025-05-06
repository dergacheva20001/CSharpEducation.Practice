using System;

class Program
{

    static void InvertArray(int[] array)
    {

        int length = array.Length;


        for (int i = 0; i < length / 2; i++)
        {

            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
    }

    static void Main(string[] args)
    {

        int[] originalArray = { 1, 2, 3, 4, 5 };


        Console.WriteLine("Исходный массив:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        
        InvertArray(originalArray);
        
        Console.WriteLine("Инвертированный массив:");
        foreach (int num in originalArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}