using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class CompareTriplets
    {
        public static List<int> Compare(List<int> listA, List<int>listB)
        {
            var counterA = 0;
            var counterB = 0;

            for (int i = 0; i < listA.Count; i++)
            {
                var a = listA[i];
                var b = listB[i];

                if (a > b) counterA++;
                
                if(a < b) counterB++;
                
            }            


            return new List<int>() { counterA, counterB } ;
        }
    }
}
