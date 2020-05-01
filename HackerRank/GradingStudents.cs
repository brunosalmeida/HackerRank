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

                if (grade < 38)
                {
                    result.Add(grade);
                    continue;
                }

                var isMultiple = false;
                var number = grade;

                while (!isMultiple)
                {
                    if (number % 5 == 0)
                        isMultiple = true;
                    else
                        number++;
                }

                if (number == grade)
                {
                    result.Add(grade);
                    continue;
                }

                if (number - grade < 3)
                    result.Add(number);

                if (number - grade == 3)
                    result.Add(grade);
            }

            return result;
        }
    }
}