using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class QuotientAndRemainder
    {
        public void QuotinetAndRemainders()
        {
            Console.WriteLine("Enter two numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int quotient = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
