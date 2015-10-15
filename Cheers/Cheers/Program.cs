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
           System.Console.WriteLine("Hey " + name + ", What's your birthday? (MM/DD)");
           string birthday = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
           name = name.ToUpper();
           string choose = "a";
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    foreach (char an in "halfnorsemix")
                    {
                        if (letter == an)
                        {
                            choose = "an";
                        }
                    }
                    System.Console.WriteLine("Give me " + choose + "..." + letter);
                }       
            } 
           System.Console.WriteLine(name + "'s just GRAND!");
           System.DateTime today = System.DateTime.Now;
           System.DateTime birthdayDate = Convert.ToDateTime(birthday);
           double days = (birthdayDate - today).TotalDays;
           if (days < 0)
            {
                days = days + 365;
            }
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
