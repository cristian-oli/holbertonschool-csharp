using System;
using System.Collections.Generic;
using System.Text;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0)
            return 0;
        int data = 0;
        foreach (int num in myLList)
        {
            data = num;
            break;
        }
        myLList.RemoveFirst();
        return data;
    }
}
