using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProblem
{
    public class RegexMethod
    {
      
         public void ValidateFirstName(string name)
         {
            //Vijay
             string firstName = "^[A-Z][a-z]{3,}?";
             if(Regex.IsMatch(name,firstName))
             {
                Console.WriteLine("First name macthing with Regex");
             }
            else
            {
                Console.WriteLine("First name not macthing with Regex");
            }
         }
        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name macthing with Regex");
            }
            else
            {
                Console.WriteLine("Last name not macthing with Regex");
            }
        }
        public void ValidateEmail(string email)
        {
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email id macthing with Regex");
            }
            else
            {
                Console.WriteLine("Email id not macthing with Regex");
            }
        }



    }
    
}
