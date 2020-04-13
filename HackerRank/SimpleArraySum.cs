using System;

namespace HackerRank
{
    public class SimpleArraySum
    {
        public static int ArraySum(int[] array)
        {
            var sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

    }
}
