//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.

//Input

//On the only line you will receive a string - the text
//Output

//Print the changed string on one line
//Input	Output
//We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.	We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseTags
{
    class Program
    {
      
            static void Main(string[] args)
        {
            //We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            string input = Console.ReadLine();
            Console.WriteLine(ParseUpcaseTags(input,"<upcase>","</upcase>"));
        }

        private static string ParseUpcaseTags(string input,string openTag,string closeTag)
        {
            StringBuilder parsedText = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i + openTag.Length < input.Length && input.Substring(i, openTag.Length).Equals(openTag))
                {
                    string textToAdd = input.Substring(
                        i + openTag.Length,
                        input.IndexOf(closeTag, i + openTag.Length) - i - closeTag.Length + 1);
                    parsedText.Append(textToAdd.ToUpper());
                    i = input.IndexOf(closeTag, i + openTag.Length) + closeTag.Length - 1;
                }
                else
                {
                    parsedText.Append(input[i]);
                }
            }

           return parsedText.ToString();
        }
    }
        }
    
