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
        static void Disemvoweler(string sentence)
        {
            //vowels
            string correctString = sentence.Replace(" ", "");
            correctString = correctString.Replace("a", "");
            correctString = correctString.Replace("e", "");
            correctString = correctString.Replace("i", "");
            correctString = correctString.Replace("o", "");
            correctString = correctString.Replace("u", "");
            Console.WriteLine("Original: " + sentence);
            Console.WriteLine("Disemvoweled: " + correctString);

            //constants
            string sentence2 = sentence;
            sentence2 = sentence2.ToLower();
            sentence2 = sentence2.Replace("b", "");
            sentence2 = sentence2.Replace("c", "");
            sentence2 = sentence2.Replace("k", "");
            sentence2 = sentence2.Replace("d", "");
            sentence2 = sentence2.Replace("j", "");
            sentence2 = sentence2.Replace("f", "");
            sentence2 = sentence2.Replace("g", "");
            sentence2 = sentence2.Replace("h", "");
            sentence2 = sentence2.Replace("l", "");
            sentence2 = sentence2.Replace("m", "");
            sentence2 = sentence2.Replace("n", "");
            sentence2 = sentence2.Replace("p", "");
            sentence2 = sentence2.Replace("q", "");
            sentence2 = sentence2.Replace("r", "");
            sentence2 = sentence2.Replace("s", "");
            sentence2 = sentence2.Replace("t", "");
            sentence2 = sentence2.Replace("v", "");
            sentence2 = sentence2.Replace("w", "");
            sentence2 = sentence2.Replace("x", "");
            sentence2 = sentence2.Replace("y", "");
            sentence2 = sentence2.Replace("z", "");
        }
    }
}
