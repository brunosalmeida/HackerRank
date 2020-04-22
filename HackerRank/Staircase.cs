using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class Staircase
    {
        public static string[] Stair(int number)
        {
            const char symbol = '#';

            var stair = new string[number];

            for (int index = 0; index < number; index++)
            {
                int counter = index + 1;
                int length = number - counter;

                string symbols = new string(symbol, counter); 

                string stairs = new String(' ', length).Insert(length, symbols);
                
                stair[index] = stairs;

                Console.WriteLine(stairs);
            }

            return stair;
        }
    }
}
