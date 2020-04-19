using System.Collections.Generic;

namespace HackerRank
{
    public class DiagonalDifference
    {
        public static int Difference(List<List<int>> arrays)
        {
            var sumResultRightToLeft = SumRightToLeftDiagonal(arrays);
            var sumResultLeftToRight = SumLeftToRightDiagonal(arrays);

            return sumResultRightToLeft - sumResultLeftToRight;
        }

        public static int SumLeftToRightDiagonal(List<List<int>> arrays)
        {
            int counter = 1;
            int difference = 0;
          
            for (int startIndex = 0; startIndex < arrays.Count; startIndex++)
            {
                var current = arrays[startIndex];
                var nextIndex = startIndex + 1;

                if (nextIndex < arrays.Count)
                {
                    var next = arrays[nextIndex];

                    if (next.Count < current.Count)
                    {
                        counter = next.Count;
                        difference = 0;

                        break;
                    }
                }

                difference += current[current.Count - counter];
                counter++;
            }

            return difference;
        }

        public static int SumRightToLeftDiagonal(List<List<int>> arrays)
        {
            int index = 0;
            int difference = 0;

            for (int startIndex = 0; startIndex < arrays.Count; startIndex++)
            {
                var current = arrays[startIndex];
                var nextIndex = startIndex + 1;

                if (nextIndex < arrays.Count)
                {
                    var next = arrays[nextIndex];

                    if (next.Count < current.Count)
                    {
                        index = 0;
                        difference = 0;

                        break;
                    }
                }

                difference += current[index];
                index++;
            }

            return difference;
        }
    }
}