using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("Hello There! What's your name?");
           string name = System.Console.ReadLine();
           System.Console.WriteLine("Hi, " + name);
           name = name.ToUpper();
           foreach (char letter in name)
            {
                string choose = "a";
                foreach (char an in "HALFNORSEMIX")
                {
                    if (letter == an)
                    {
                        choose = "an";
                    }
                }
             System.Console.WriteLine("Give me " + choose + " " + letter);            
            }                          
           System.Console.ReadKey();
        }
    }
}
