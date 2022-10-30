using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number =16;
            int foundNumber = 0;

            for ( int i = number; i > 1; i= i / 2)
            {
                foundNumber = i;
                
            }
            if (foundNumber /2 == 1)
            {
                Console.WriteLine("it is power of 2");

            }
            else
            {
                Console.WriteLine("it is not power of 2");
            }
        }
    }
}
