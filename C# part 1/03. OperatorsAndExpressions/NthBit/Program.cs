using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NthBit
{
    class Program
    {
        static void Main(string[] args)
        {
        string stNumber = Console.ReadLine();
        long number = long.Parse(stNumber);
        string stP = Console.ReadLine();
        int p = int.Parse(stP);
        byte bitAtPositionP = (byte)((number >> p) & 1);
        Console.WriteLine("{0}", bitAtPositionP);
    }
}
        }
    