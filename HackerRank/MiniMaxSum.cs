namespace HackerRank
{
    public class MiniMaxSum
    {
        public static string Sum(int[] array)
        {
            var max = 0;
            var min = 0;

            for (int index = 0; index < array.Length; index++)
            {
                var tmp = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (index != i)
                    {
                        tmp += array[i];
                    }
                }

                if (max == 0 || tmp > max)
                {
                    max = tmp;
                }

                if (min == 0 || tmp < min)
                {
                    min = tmp;
                }
            }

            return $"{min} {max}";
        }
    }
}
