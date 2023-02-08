using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class Factors
    {
        public void PrimeFactors()
        {
            Console.WriteLine("Enter the Numaber");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The prime factors of " + n + " are: ");
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            Console.WriteLine();
        }
    }
}
