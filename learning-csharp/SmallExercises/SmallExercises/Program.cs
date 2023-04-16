﻿internal class Program
{
    // For loop - Factorial
    public static void Main(string[] args)
    {
        // the following is 3x2 array 
        // you can modify the numbers as you wish
        var numbersArray = new int[,]
        {
            {3, 5},
            {-1, 12},
            {4, 0}
        };
        Console.WriteLine("The maximum number in the given array is " + FindMax(numbersArray));
        Console.WriteLine("press any key to exist the program");
        Console.ReadKey();
    }

    private static int FindMax(int[,] numbersArray)
    {
        int height = 0;
        int width = 0; 

        height = numbersArray.GetLength(0);
        width = numbersArray.GetLength(1);

        if(height == 0) { return -1; }
        if(width == 0) { return -1; }

        // maxNumber 
        int maxNumber = numbersArray[0, 0];

        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                var number = numbersArray[i, j];
                if(number> maxNumber)
                {
                    maxNumber = number;
                }
            }
        }
        return maxNumber;
    }
}