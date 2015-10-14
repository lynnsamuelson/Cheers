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
           System.Console.WriteLine("What's your birthday?");
           string birthday = System.Console.ReadLine();
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
           System.Console.WriteLine(name + "'s just GRAND!");
           System.DateTime today = System.DateTime.Now;
           System.DateTime birthdayDate = Convert.ToDateTime(birthday);
          (today - birthdayDate).Days;
            System.Console.WriteLine("Your Birthday is in " + days + "days.");                   
           System.Console.ReadKey();
        }
    }
}
