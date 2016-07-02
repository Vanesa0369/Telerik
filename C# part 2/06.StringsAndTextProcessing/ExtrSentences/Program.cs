using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrSentences
{
    class Program
    {
        static void Main(string[] args)
        
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        var sentences = text.Split('.');

        var result = new StringBuilder();

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(new[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (Array.IndexOf(words, word) > -1)
            {
                result.Append(sentence.Trim());
                result.Append(". ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}
}
