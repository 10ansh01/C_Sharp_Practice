using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int i = 0;
        int j = 0;

        int[] array1 = new int[6] { 33, 45, 67, 80, 4, 10000 };
        int[] array2 = new int[6] { 3, 78, 49, 36, 1000, 98 };
        int[] finalArray = new int[12];

        for (i = 0, j = 0; i < 6; i++)
        {
            finalArray[j++] = array1[i];
        }
        for (i = 0; i < 6; i++)
        {
            finalArray[j++] = array2[i];
        }

        Array.Sort(finalArray);

        foreach (int value in finalArray)
        {
            Console.Write(value + " ");
        }

        Console.WriteLine();
    }
}