using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class SwapTwoValue
    {
        public void SwapTwo()
        {
            Console.WriteLine("Enter two numbers to swap:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping, the numbers are: " + num1 + " and " + num2);

            int temp = num1; //10
            num1 = num2; // 10, 20   = 20
            num2 = temp; // 20 , 10  = 10

            Console.WriteLine("After swapping, the numbers are: " + num1 + " and " + num2);
        }
    }
}
