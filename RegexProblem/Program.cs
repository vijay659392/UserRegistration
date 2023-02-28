using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexMethod regex = new RegexMethod();
            regex.ValidateFirstName("Vijay");
            regex.ValidateLastName("Durkikar");
            regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            regex.ValidatePhoneNumber("91 7729937460");
            Console.ReadLine();
        }
    }
}
