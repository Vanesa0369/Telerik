using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingOfQuotationsInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string str1 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("{0}", str1);
        }
    }
}
