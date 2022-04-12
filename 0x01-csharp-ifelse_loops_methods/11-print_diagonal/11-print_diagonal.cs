using System;

    class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length < 1)
        {
            Console.WriteLine();
            return;
        }
        String line = "\\";
        String space = " ";
        for (int i = 0; i < length; i++)
        {   
            if (i > 0)
                space += " ";
            Console.WriteLine("{0}{1}", space, line);
        }
    }
}
