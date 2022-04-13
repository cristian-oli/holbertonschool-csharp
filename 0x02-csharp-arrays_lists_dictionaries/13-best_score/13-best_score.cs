using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int current = 0;
        string _key = "";

        if (myList.Count == 0)
            return "None";

        foreach ((string key, int value) in myList)
        {
            if (value >= current)
            {
                current = value;
                _key = key;
            }
        }
        return _key;
    }
}
