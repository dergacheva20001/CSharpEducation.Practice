using System;

class Program
{

    static int[] CreateArray(int size)
    {

        int[] array = new int[size];


        Random random = new Random();

 
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100); 
        }

        return array;
    }

    static void PrintArray(int[] array)
    {

        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Массив пустой или не существует.");
            return;
        }

        Console.WriteLine("Элементы массива:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine(); 
    }

    static void Main(string[] args)
    {

        int size = 10; 
        int[] myArray = CreateArray(size); 
        PrintArray(myArray); 
    }
}