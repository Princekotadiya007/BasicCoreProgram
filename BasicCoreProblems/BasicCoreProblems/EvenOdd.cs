using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is an even number.");
            else
                Console.WriteLine(num + " is an odd number.");
        }
    }
}
