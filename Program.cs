using System;
using System.Numerics;

namespace Data_Types_and_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            // we can also use BigInteger to avoid overflow
            // note that int + int = int even if our variable is type long
            // in that case it will overflow if one of the two int is not converted to long

            long firstResult = (long)num1 + num2;
            long secondResult = firstResult / num3;
            long  firanResult = (long)secondResult * num4;
            Console.WriteLine(firstResult);
        }
    }
}
