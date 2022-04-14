using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int> (list1);
        foreach(int number in list2)
        {
            if (newList.Contains(number))
                newList.Remove(number);
            else
                newList.Add(number);
        }
        newList.Sort();
        return newList;
    }
}
