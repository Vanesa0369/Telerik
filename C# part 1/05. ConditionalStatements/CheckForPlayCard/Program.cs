using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckForPlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string character =  Console.ReadLine();
            switch(character)
            {
                case "2": Console.WriteLine("yes" + " " + "2");
                    break;
                case "3": Console.WriteLine("yes" + " " + "3");
                    break;
                case "4": Console.WriteLine("yes" + " " + "4");
                    break;
                case "5": Console.WriteLine("yes" + " " + "5");
                    break;
                case "6": Console.WriteLine("yes" + " " + "6");
                    break;
                case "7": Console.WriteLine("yes" + " " + "7");
                    break;
                case "9": Console.WriteLine("yes" + " " + "9");
                    break;
                case "10": Console.WriteLine("yes" + " " + "10");
                    break;
                case "A": Console.WriteLine("yes" + " " + "A");
                    break;
                case "J": Console.WriteLine("yes" + " " + "J");
                    break;
                case "K": Console.WriteLine("yes" + " " +"K");
                    break;
                case "Q": Console.WriteLine("yes" + "Q");
                    break;
                    
                default: Console.WriteLine("no" + " " + character);
                    break;

                    }
            

        }
    }
}
