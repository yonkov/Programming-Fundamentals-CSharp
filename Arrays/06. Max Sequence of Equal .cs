using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int start = 0;
        int count = 0;
        int max = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (count > max)
                {
                    start = i - count;
                    max = count;
                }
            }
            else
            {
                count = 0;
            }
        }
        for (int i = start + 1; i <= start + max + 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}