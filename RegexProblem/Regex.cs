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

  
    }
    
}
