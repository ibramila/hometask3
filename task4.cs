using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın (switch case ilə yazın)
            
            string month = "March";

            switch (month) {
                case "December":
                Console.WriteLine("winter");
                break;
                case "January":
                    Console.WriteLine("winter");
                    break;    
                case "February":
                    Console.WriteLine("winter");
                    break;
                case "March":
                    Console.WriteLine("spring");
                    break;  
                case "April":
                    Console.WriteLine("spring");
                    break;    
                case "May":
                    Console.WriteLine("spring");
                    break;    
                case "June":
                    Console.WriteLine("summer");
                    break;    
                case "July":
                    Console.WriteLine("summer");
                    break;    
                case "August":
                    Console.WriteLine("summer");
                    break;    
                case "September":
                    Console.WriteLine("fall");
                    break;    
                case "October":
                    Console.WriteLine("fall");
                    break;     
                case "November":
                    Console.WriteLine("fall");
                    break; 
                    }

        }
    }
}
