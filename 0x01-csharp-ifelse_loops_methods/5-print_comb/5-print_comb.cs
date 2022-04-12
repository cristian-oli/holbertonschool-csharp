using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; i < 100; i++) {
                if (i != 99)
                    Console.Write("{0}, ", i.ToString("00"));
                else
                    Console.Write("{0}\n", i.ToString("00"));
            }
        }
    }
}
