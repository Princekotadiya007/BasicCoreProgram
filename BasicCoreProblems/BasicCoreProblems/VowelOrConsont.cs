using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class VowelOrConsont
    {
        public void VowelConsonant()
        {
            char letter;
            Console.WriteLine("Enter a alphabet letter");
            letter = (Char)Console.Read();

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
                letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("The letter is a vowel.");
            }
            else
            {
                Console.WriteLine("The letter is a consonant.");
            }
        }
    }
}
