using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = BigInteger.MinusOne;
            // these are jsut varianblse holding the properties of a maxed smnowball
            // we need them just for the output
            int maxSnow = 0;
             int maxTime = 0;
            int maxQuality = 0;
            // n = tital snowballs
            for (int i = 0; i < n; i++)
            {
                //for each snowball we read 3 lines
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());  
                int snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);
                if (snowBallValue >maxValue)
                {
                    maxValue = snowBallValue;
                    maxSnow = snowBallSnow;
                    maxTime = snowBallTime;
                    maxQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue}({maxQuality})");
        }
    }
}
