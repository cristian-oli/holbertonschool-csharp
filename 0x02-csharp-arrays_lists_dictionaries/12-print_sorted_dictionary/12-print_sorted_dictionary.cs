using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> my_Dict = new SortedList<string, string> (myDict);
        
        foreach ((string key, string value) in my_Dict)
        {
            Console.WriteLine("{0}: {1}", key, value);
        }
    }
}
