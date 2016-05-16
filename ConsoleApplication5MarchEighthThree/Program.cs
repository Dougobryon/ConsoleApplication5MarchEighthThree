using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5MarchEighthThree
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Movie theater for R-rated movie*/

            Console.WriteLine("What is your age?:");
            int age = int.Parse(Console.ReadLine());
            if (age >= 17)
            {
                Console.WriteLine("Come on in");
            }
            else
            {
                Console.WriteLine("Go Home");
            }
                     
            
            }
    }
}




    
