using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> head = myLList.First;
        while (head != null)
        {
            if (head.Value < n)
                head = head.Next;
            else
            {
                myLList.AddBefore(head, n);
                return myLList.First;
            }
        }
        myLList.AddLast(n);
        return myLList.First;
    }
}
