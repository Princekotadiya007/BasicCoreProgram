using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class Harmonic
    {
        public void HarmonicNumber()
        {
            Console.WriteLine("Enter the value of N: ");
            int n = int.Parse(Console.ReadLine());

            double harmonicValue = 0;
            for (int i = 1; i <= n; i++)
            {
                harmonicValue += (1.0 / i);
            }

            Console.WriteLine("The " + n + "th harmonic value is: " + harmonicValue);
        }
    }
}
