using System;

class Program
{
    static void Main()
    {

        int length = 10;
        int[] array = new int[length];

       
        Random random = new Random(); 
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 101); 
        }

        int maxValue = array[0]; 
        int minValue = array[0]; 

        for (int i = 1; i < length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i]; 
            }
            if (array[i] < minValue)
            {
                minValue = array[i]; 
            }
        }
        int difference = maxValue - minValue;
        
        Console.WriteLine("Массив: " + string.Join(", ", array)); 
        Console.WriteLine("Максимальное значение: " + maxValue); 
        Console.WriteLine("Минимальное значение: " + minValue); 
        Console.WriteLine("Разница между максимальным и минимальным значениями: " + difference); 
    }
}