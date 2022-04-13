using System;
using System.Collections.Generic;

class List
{
   public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        
        int current = Int32.MinValue;
        foreach (int number in myList)
        {
            if (number >= current)
                current = number;
        }
        return current;
    }
}
