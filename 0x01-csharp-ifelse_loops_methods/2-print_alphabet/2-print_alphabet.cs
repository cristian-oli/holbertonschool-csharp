using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            for (;i < 123; i++)
                Console.Write("{0}", (char)i);
        }
    }
}
