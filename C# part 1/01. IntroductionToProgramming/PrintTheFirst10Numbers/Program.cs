using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintTheFirst10Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 2; i <12; i++)
			{
			 if (i % 2 == 0)
             {
                 Console.WriteLine("{0}" , i );
             }
             else
             {
                 Console.WriteLine("{0}", -i);
             }
			}
            
            }

              
            }

        }
    

