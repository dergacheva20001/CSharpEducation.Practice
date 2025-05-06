using System;

class Program
{
    static void Main()
    {

        int[] originalArray = { 1, -2, 3, -4, 5, -6 };

        int[] newArray;
        int removedCount;
        newArray = RemoveNegativeNumbers(originalArray, out removedCount);

        Console.WriteLine("Новый массив без отрицательных чисел:");
        foreach (int number in newArray)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Количество удалённых отрицательных чисел: " + removedCount);
    }

    /// <summary>
    /// Метод для удаления отрицательных чисел из массива.
    /// </summary>
    /// <param name="inputArray">Исходный массив чисел.</param>
    /// <param name="removedCount">Количество удалённых отрицательных чисел.</param>
    /// <returns>Новый массив без отрицательных чисел.</returns>
    static int[] RemoveNegativeNumbers(int[] inputArray, out int removedCount)
    {

        removedCount = 0;

        int positiveCount = 0;
        foreach (int number in inputArray)
        {
            if (number >= 0)
            {
                positiveCount++;
            }
        }

        int[] resultArray = new int[positiveCount];
        int index = 0;


        foreach (int number in inputArray)
        {
            if (number >= 0)
            {
                resultArray[index] = number;
                index++;
            }
            else
            {
                removedCount++;
            }
        }

        return resultArray;
    }
}