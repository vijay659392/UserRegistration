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
            Console.ReadLine();
        }
    }
}
