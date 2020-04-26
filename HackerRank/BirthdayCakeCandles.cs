namespace HackerRank
{
    public class BirthdayCakeCandles
    {
        public static int Calc(int[] array)
        {
            var counter = 0;

            var max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var tmp = array[i];

                if (tmp > max)
                    max = tmp;
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (max == array[j])
                    counter++;
            }           

            return counter;
        }
    }
}
