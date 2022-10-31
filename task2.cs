using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 121; 
            int mod= 0;
            int foundNumber = 0; 
            for (int i=number; i>=1; i=i/10)
            {
                mod = i%10;
                foundNumber = mod + foundNumber;
                if (i>=10) {foundNumber = foundNumber * 10; }
            }
            if (foundNumber == number) { Console.WriteLine("It is a palindrom number");
            }
            else { Console.WriteLine("It is not a palindrom number"); }
        }
    }
}