using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hello(name);
        }

        static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    
    }
}
