using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string input = Console.ReadLine();


            switch ( input)
            {
                case "integer":
                    int inputOne = int.Parse(Console.ReadLine());
                Console.WriteLine(inputOne + 1);
                break;
                case "real":
                     double inputTwo = double.Parse(Console.ReadLine());
                Console.WriteLine( "{0:0.00}", inputTwo + 1);
                break;
                case "text":
                string inputThree = Console.ReadLine();
                Console.WriteLine(inputThree + "*");
                break;
                
                    


            }
        }
    }
}
