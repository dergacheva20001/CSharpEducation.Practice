using System;

class Program
{

    static int[,] Create2DArray(int rows, int columns)
    {

        int[,] array = new int[rows, columns];


        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(1, 100); 
            }
        }

        return array;
    }
    
    static void Print2DArray(int[,] array)
    {

        int rows = array.GetLength(0);
        int columns = array.GetLength(1);


        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + "\t"); 
            }
            Console.WriteLine(); 
        }
    }

    static void Main(string[] args)
    {

        int rows = 5;
        int columns = 5;

        int[,] array = Create2DArray(rows, columns);

        Print2DArray(array);
    }
}