using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRank
{
    internal class Kangaroo
    {
        /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string yes = "YES";
            string no = "NO";
            int k1= 0;
            while (k1 <= 10000)
            {
                if (x1 + v1 == x2 + v2)
                {
                    return yes;
                }
                else
                {
                    x1 += v1;
                    x2 += v2;
                    k1++;
                }
            }
            return no;
        }
    }
}
