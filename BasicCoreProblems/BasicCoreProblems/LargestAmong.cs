using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class LargestAmong
    {
        public void LargestNumber()
        {
            int num1, num2, num3;

            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The largest number is: " + num1);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("The largest number is: " + num2);
                }
                else
                {
                    Console.WriteLine("The largest number is: " + num3);
                }
            }
            Console.ReadLine();
        }
    }
}
