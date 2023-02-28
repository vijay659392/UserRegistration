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
                Console.WriteLine("First name matching with Regex");
             }
            else
            {
                Console.WriteLine("First name not matching with Regex");
            }
         }
        public void ValidateLastName(string name)
        {
            string lastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, lastName))
            {
                Console.WriteLine("Last name matching with Regex");
            }
            else
            {
                Console.WriteLine("Last name not matching with Regex");
            }
        }
        public void ValidateEmail(string email)
        {
            //abc.xyz@bridgelabz.co.in
            string emailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-]{2}){0,1}$";

            if (Regex.IsMatch(email, emailID))
            {
                Console.WriteLine("Email id is matching with Regex");
            }
            else
            {
                Console.WriteLine("Email id is not matching with Regex");
            }
        }
        public void ValidatePhoneNumber(string phoneNumber)
        {
            //"91 7729937460"
            string phoneNum = @"[0-9]{1,2}\s[0-9]{10}";
            if (Regex.IsMatch(phoneNumber, phoneNum))
            {
                Console.WriteLine("Phone Number is matching with Regex");
            }
            else
            {
                Console.WriteLine("Phone Number is not matching with Regex");
            }
        }
        public void ValidatePassword(string pswd)
        {
            string password = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(pswd, password))
            {
                Console.WriteLine("Password is matching with Regex");
            }
            else
            {
                Console.WriteLine("Password not is matching with Regex");
            }
        }

    }
    
}
