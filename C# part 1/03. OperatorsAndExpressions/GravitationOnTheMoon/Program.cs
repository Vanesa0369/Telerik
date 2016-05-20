using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());
            double weightMoon = (weight * 0.17);
            Console.WriteLine("{0:0.000}",weightMoon);
        }
    }
}
