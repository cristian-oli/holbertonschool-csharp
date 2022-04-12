using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        Console.Write("The last digit of {0} is {1} and is ", number, number % 10);
        if (number % 10 > 5)
            Console.WriteLine("greater than 5");
        else if (number % 10 == 0)
            Console.WriteLine("0");
        else if (number % 10 < 6 && number != 0)
            Console.WriteLine("less than 6 and not 0");
    }
}
