using System;

class Program
{
    static void Main()
    {
        int size = 5;
        
        string[] array = new string[size];
        
        for (int i = 0; i < size; i++)
        {
 
            Console.Write($"Введите строку {i + 1}: ");
            
            array[i] = Console.ReadLine();
        }
        
        Console.WriteLine("\nВы ввели следующие строки:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}