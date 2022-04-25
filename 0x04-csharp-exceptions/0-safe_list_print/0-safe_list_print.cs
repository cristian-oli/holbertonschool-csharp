using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i = 0, prints = 0;

        while (i < n)
        {
            try
            {
                Console.WriteLine(myList[i]);
            }
            catch (ArgumentOutOfRangeException)
            {
                i++;
                continue;
            }
            prints++;
            i++;
        }
        
        return prints;
    }
}
