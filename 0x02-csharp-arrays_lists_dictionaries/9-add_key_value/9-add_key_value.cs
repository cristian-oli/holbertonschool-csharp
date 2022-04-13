using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        bool tag = false;
        foreach ((string itemKey, string itemValue) in myDict)
        {
            if (key == itemValue)
                tag = true;
        }
        if (tag)
            myDict[key] = value;
        else
            myDict.Add(key, value);
        return myDict;
    }
}
