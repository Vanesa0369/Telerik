//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

//Input

//On the only line you will receive an address
//Output

//Print the protocol, server and resource as shown below
//Input	                                                Output
//http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http
//                                                        [server] = telerikacademy.com
//                                                         [resource] = /Courses/Courses/Details/212
//https://github.com/gentoo/gentoo.git	             [protocol] = https
//                                                   [server] = github.com
//                                                   [resource] = /gentoo/gentoo.git



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class Program
    {
        

    static string parseProtocol(string text, int lastIndex)
    {
        string protocol = text.Substring(0, lastIndex);
        return protocol;
    }
    static string parseServer(string text, int startIndex, int lastIndex)
    {
        lastIndex = lastIndex - startIndex;
        string server = text.Substring(startIndex, lastIndex);
        return server;
    }
    static string parseResource(string text, int startIndex)
    {
        int from = startIndex;
        int lastIndex = text.Length - from;
        string resource = text.Substring(from, lastIndex);
        return resource;
    }
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        int protocolServer = text.IndexOf("://");
        int serverResource = text.IndexOf('/', protocolServer + 3);
        string protocol = parseProtocol(text, protocolServer);
        string server = parseServer(text, protocolServer + 3, serverResource);
        string resource = parseResource(text, serverResource);
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + resource);
    }
}
        }
    
