using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertAnywayBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int fromBase = 16;
            int toBase = 10;
            String result = Convert.ToString(Convert.ToInt64(number, fromBase), toBase).ToUpper();
            Console.WriteLine(result);
        }
    }
}
