using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (; number < 99; number++)
                Console.WriteLine("{0} = 0x{1}", number, number.ToString("x"));
        }
    }
}
