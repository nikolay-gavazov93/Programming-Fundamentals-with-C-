using System;

namespace _5._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            //char to int / int to char
            for (int i = startIndex; i <= endIndex; i++)
            {
                //we have numeric value of the character in our memery
                // we need to cast in order to get visual representation of the number
                char currCh = (char)i;
                Console.WriteLine(currCh + "  ");
            }

             // or 
            for (char ch = 'a'; ch < 'd'; ch++)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
