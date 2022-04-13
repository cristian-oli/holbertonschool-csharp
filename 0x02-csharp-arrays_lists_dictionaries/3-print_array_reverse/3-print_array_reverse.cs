using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        if (array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        int[] newArray = new int[array.Length];
        // int[] newArray = array;
        for (int i = array.Length - 1, j = 0; i >= 0 || j < array.Length; i--, j++)
        {
            newArray[j] = array[i];
            Console.Write(newArray[j]);
            if (i != 0)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
