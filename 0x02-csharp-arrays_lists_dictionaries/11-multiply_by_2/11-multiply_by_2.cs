using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> newDict = new Dictionary<string, int> ();
        foreach ((string key, int value) in myDict)
        {
            newDict.Add(key, value * 2);
        }
        return newDict;
    }
}
