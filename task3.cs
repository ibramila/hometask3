using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            int numberOfDivisors = 0;
            for (int i=1; i<=number; i++)
            {
                if (number%i==0) { numberOfDivisors++; }
            }
            if (numberOfDivisors <= 2) { Console.WriteLine("it is a prime number."); }
            else { Console.WriteLine("it is not a prime number"); }

        }
    }
}