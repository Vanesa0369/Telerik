using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int BonusTochki = int.Parse(Console.ReadLine());
            
            switch(BonusTochki)
            {
                case 1:
                case 2:
                case 3:Console.WriteLine(BonusTochki * 10);break;
                case 4:
                case 5:
                case 6:Console.WriteLine(BonusTochki * 100);break;
                case 7:
                case 8:
                case 9:Console.WriteLine(BonusTochki * 1000);break;
                default: if ((BonusTochki == 0) || (BonusTochki > 9 ))
                    {
                        Console.WriteLine("invalid score"); ;
                    }
                    break;
                      

            }
        }
    }
}
