﻿using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (int number in myLList)
        {
            if (n == index)
                return number;
            index++;
        }
        return 0;
    }
}
