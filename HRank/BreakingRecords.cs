using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRank
{
    internal class BreakingRecords
    {
        /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

        public static List<int> breakingRecords(List<int> scores)
        {
            if (scores.Count == 0)
            {
                return null;
            }
            int max = scores[0];
            int min = scores[0];
            int upScore = 0;
            int downScore = 0;
            for (int i = 1; i < scores.Count; i++) {
                if (scores[i] > max)
                {
                    upScore++;
                    max = scores[i];
                }
                if (scores[i] < min)
                { 
                    downScore++;
                    min = scores[i];
                }
            }
            return new List<int> { upScore, downScore };
        }
    }
}
