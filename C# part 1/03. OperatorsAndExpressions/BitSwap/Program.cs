using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            
        uint number = uint.Parse(Console.ReadLine());

        int p = int.Parse(Console.ReadLine());

        int q = int.Parse(Console.ReadLine());

        int k = int.Parse(Console.ReadLine());



        for (int i = 0; i <= (k - 1); i++)
        {
            if (((number >> p) & 1) != ((number >> q) & 1))
            {
                number = number ^ (1u << p);
                number = number ^ (1u << q);
            }
            p++;
            q++;
        }

        Console.WriteLine("{0}", number);
    }
}
        }
    