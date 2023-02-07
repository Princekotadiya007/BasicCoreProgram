using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    public class FlipCoin
    {
        int countHead = 0;
        int countTail = 0;
        public void Coin()
        {
            Console.WriteLine("Enter the flip the coin");
            int FlipNum = Convert.ToInt32(Console.ReadLine());

            Random random= new Random();
            for(int i=0; i<FlipNum; i++)
            {
                double numCheck = random.NextDouble();
                if (numCheck > 0.5)
                    countHead++;
                else
                    countTail++;
            }
            Console.WriteLine("count of head:"+ countHead);
            Console.WriteLine("count of Tail:" + countTail);

            float headPercentage = (float)countHead / countTail * 100;
            float tailPercentage = (float)countTail / countHead * 100;

            Console.WriteLine("Percentage of Head:"+ headPercentage);
            Console.WriteLine("percentage of Tail: " +tailPercentage);
        }
    }
}
