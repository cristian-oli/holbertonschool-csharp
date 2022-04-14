using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLL = new LinkedList<int>();

        if (size < 0)
            return myLL;

        int i = 0;

        while (i< size)
        {
            myLL.AddFirst(i);
            Console.WriteLine(i);
            i++;
        }
        
        return myLL;
    }
}
