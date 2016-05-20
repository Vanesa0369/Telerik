using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintAgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            int ageNow = (int)((DateTime.Now - birthDay).TotalDays / 365.242199);
            int AgeAfter10 = ageNow + 10;
            Console.WriteLine(ageNow);
            Console.WriteLine(AgeAfter10);
            



        }
    }
}
