using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciMemoization
    {
        public static long FibRec(int n, long[] memo = null)
        {
            if (memo == null)
            {
                memo = new long[n];
            }

            if (memo[n - 1] != 0)
            {
                return memo[n - 1];
            }

            if (n <= 2)
            {
                memo[n - 1] = 1;
                return 1;
            }

            memo[n - 1] = FibRec(n - 1, memo) + FibRec(n - 2, memo);

            return memo[n - 1];
        }

        public static long FibIterative(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            long[] memo = new long[n];
            memo[0] = 1;
            memo[1] = 1;

            for (int i = 2; i < n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }

            return memo[n - 1];
        }
    }
}
