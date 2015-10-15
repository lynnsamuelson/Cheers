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
           System.Console.WriteLine(birthdayDate);
           double days = (birthdayDate - today).TotalDays;
           double numDays = Math.Round(days);
           if (numDays == 0)
            {
                System.Console.WriteLine("Happy Birthday!");
            } 
           else if (numDays == 1)
            {
                System.Console.WriteLine("Your Birthday is in " + numDays + " day.");
            }
           else
            {
                System.Console.WriteLine("Your Birthday is in " + numDays + " days.");
            }
                                  
           System.Console.ReadKey();
        }
    }
}
