using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length < 1)
        {
            Console.WriteLine();
            return;
        }

        string line = "_";
        for (int i = 0; i < length + 1; i++)
            line += "_";
        Console.WriteLine(line);
    }
}
