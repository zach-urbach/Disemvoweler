using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //this program will be awesome
            
            Console.WriteLine("The Disemvoweler");
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.WriteLine();
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Console.WriteLine();
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Console.WriteLine();

            //keeps console open
            Console.ReadKey();
        }
       

    }
}
