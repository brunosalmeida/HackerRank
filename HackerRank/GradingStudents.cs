using System.Collections.Generic;

namespace HackerRank
{
    public class GradingStudents
    {
        public static List<int> Round(List<int> grades)
        {
            var result = new List<int>();

            foreach (var grade in grades)
            {
                if (grade > 100) continue;

                if (grade < 38 || grade % 5 < 3)
                {
                    result.Add(grade);
                    continue;
                }
                else
                {
                    result.Add(grade + (5 - grade % 5));
                }
               
            }

            return result;
        }
    }
}