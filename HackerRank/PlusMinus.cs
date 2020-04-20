using System;

namespace HackerRank
{
    public class PlusMinus
    {
        public static double[] PrintPlusMinus(int[] array)
        {
            double positiveCounter = 0;
            double negativeCounter = 0;
            double neutroCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    positiveCounter++;
                else if (array[i] < 0)
                    negativeCounter++;
                else
                    neutroCounter++;
            }

            double positiveFractionResult = Math.Round((positiveCounter / array.Length), 6);
            double negativeFractionResult = Math.Round((negativeCounter / array.Length), 6);
            double neutroFractionResult = Math.Round((neutroCounter / array.Length), 6);



            return new double[] { positiveFractionResult, negativeFractionResult, neutroFractionResult };
        }
    }
}
