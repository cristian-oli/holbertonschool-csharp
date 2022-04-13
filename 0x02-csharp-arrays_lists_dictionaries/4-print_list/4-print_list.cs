﻿using System;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList = new List<int> ();
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
            return newList;
        }
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i);
            if (i != size - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
        return newList;
    }
}
