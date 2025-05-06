using System;

class Program
{

    static int[] CreateEmptyArray(int n)
    {
     
        int[] array = new int[n];

        return array;
    }

    static void Main(string[] args)
    {

        int n = 5;


        int[] myArray = CreateEmptyArray(n);


        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = i * 2; 
        }

        Console.WriteLine("Содержимое массива:");
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine($"Элемент {i}: {myArray[i]}");
        }
    }
}