using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 97;
            for (;i < 123; i++) {
                if ((char)i == 'q' || (char)i == 'e')
                    Console.Write("");
                else
                    Console.Write("{0}", (char)i);
            }
        }
    }
}
