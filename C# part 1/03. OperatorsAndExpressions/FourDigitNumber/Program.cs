using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
             int number = int.Parse(Console.ReadLine());

        //fourth digit
        int firstDigit = number % 10;

        //third digit
        int restNumberTwo = number / 10;
        int secondDigit = restNumberTwo % 10;

        //second digit
        int restNumberThree = number / 100;
        int thirdDigit = restNumberThree % 10;

        //first digit
        int restNumberFour = number / 1000;
        int fourthDigit = restNumberFour % 10;

       
        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
    }
}
        }
    

