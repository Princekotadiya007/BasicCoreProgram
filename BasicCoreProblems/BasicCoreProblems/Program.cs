using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.FlipCoin, \n2 LeapYear, \n3 PowerOfTwo, \n4 HarmonicNumber, \n5 Factors, \n6 QuotientAndRemainder, \n7 SwapTwoValue \n8 Even or Odd \n9 VowelOrConsonant, \n10 LargestNumber");
            Console.WriteLine("Enter a option");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.Coin();
                    break;
                case 2:
                    LeapYear year = new LeapYear();
                    year.Checkyear();
                    break;
                case 3: 
                    PowerOfTwo squreTwo = new PowerOfTwo();
                    squreTwo.Table();
                    break;
                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.HarmonicNumber();
                    break;
                case 5:
                    Factors factors = new Factors();
                    factors.PrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder QR = new QuotientAndRemainder();
                    QR.QuotinetAndRemainders();
                    break;
                case 7:
                    SwapTwoValue swapTwoValue = new SwapTwoValue();
                    swapTwoValue.SwapTwo();
                    break;
                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.EvenOrOdd();
                    break;
                case 9:
                    VowelOrConsont vowel= new VowelOrConsont();
                    vowel.VowelConsonant();
                    break;
                case 10:
                    LargestAmong largestAmong = new LargestAmong();
                    largestAmong.LargestNumber();
                    break;
                default:
                    Console.WriteLine("Choose a Correct option");
                    break;
            }
        }
    }
}
