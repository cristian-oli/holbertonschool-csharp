using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index > array.Length || index < 0)
        {
            Console.WriteLine("Index out of range");
            return array;
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
                array[i] = n;
        }
        return array;
    }
}
