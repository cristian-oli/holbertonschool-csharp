using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        Console.Write("{0}", System.Math.Abs(number % 10));
        return System.Math.Abs(number % 10);
    }
}
