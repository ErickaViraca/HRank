using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRank
{
    internal class FizzBuzz
    {
        /*
     * Complete the 'fizzBuzz' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 5 != 0) { Console.WriteLine(i); }
                else if (i%3 == 0 && i%5 == 0) { Console.WriteLine("FizzBuzz");}
                else if (i % 3 == 0 && i % 5 != 0) { Console.WriteLine("Fizz"); }
                else if (i % 3 != 0 && i % 5 == 0) { Console.WriteLine("Buzz"); }
            }
        }
    }
}
