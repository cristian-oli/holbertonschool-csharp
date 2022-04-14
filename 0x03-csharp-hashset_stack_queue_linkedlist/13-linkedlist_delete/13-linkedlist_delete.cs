using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> head = myLList.First;
        int counter = 0;

        while (head != null)
        {
            if (counter == index)
            {
                myLList.Remove(head);
            }
            counter++;
            head = head.Next;
        }
    }
}
