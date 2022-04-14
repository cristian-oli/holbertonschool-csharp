using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> newList = new List<int> ();
        foreach(int number1 in list1)
        {
            foreach(int number2 in list2)
            {
                if (number1 == number2)
                    newList.Add(number1);
            }
        }
        newList.Sort();
        return newList;
    }
}
