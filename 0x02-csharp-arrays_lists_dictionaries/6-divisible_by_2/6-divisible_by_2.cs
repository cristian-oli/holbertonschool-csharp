using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> boleans = new List<bool> ();

        foreach(int number in myList)
        {
            if (number % 2 == 0)
                boleans.Add(true);
            else
                boleans.Add(false);
        }
        return boleans;
    }
}
