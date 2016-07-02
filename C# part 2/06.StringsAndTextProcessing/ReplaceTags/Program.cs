﻿//Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).

//Input

//On the only input line you will receive a string
//Output

//Print the string with replaced tags
//Input	Output
//<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    class Program
    {
        static void Main(string[] args)
       
    {
        string text = Console.ReadLine();
        string parsedHTML = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
        Console.WriteLine(parsedHTML);
    }
        }
    }

