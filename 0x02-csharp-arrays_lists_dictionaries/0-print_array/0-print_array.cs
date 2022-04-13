using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        int[] newArray = new int[size];
        for (int number = 0; number < size; number++)
        {
            Console.Write(number);
            if (number != size - 1)
            {
                Console.Write(" ");
            }
            newArray[number] = number;
        }
        Console.WriteLine();
        return newArray;
    }
}
