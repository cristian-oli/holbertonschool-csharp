using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        List<int> distinct = myList.Distinct().ToList();
        foreach(int number in distinct)
            total += number;
        return total;
    }
}
