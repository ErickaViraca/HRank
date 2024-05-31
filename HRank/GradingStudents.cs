using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRank
{
    internal class GradingStudents
    {
        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */

        public static List<int> gradingStudents(List<int> grades)
        {
            if (grades[0] <= 0)
            {
                return null;
            }
            List<int> results = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                results.Add(roundGrade(grades[i]));
            }
            return results;
        }

        private static int roundGrade(int grade)
        {
            if (grade > 0 && grade < 38)
            { return grade; }
            else
            {
                return verifyAndUpper(grade);
            }
        }

        private static int verifyAndUpper(int grade)
        {
            if ((grade / 5) == 0)
            { return grade; }
            else
            {
                int factor = (grade / 5) + 1;
                int multiplyBy = factor * 5;
                if ((multiplyBy - grade) >= 3)
                { return grade; }
                else { return multiplyBy; }
            }
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }

}
