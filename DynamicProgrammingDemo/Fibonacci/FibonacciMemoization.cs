using System.Collections.Generic;

namespace Fibonacci
{
    public static class FibonacciMemoization
    {
        public static long FibRecArray(int n, long[] memo = null)
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

            memo[n - 1] = FibRecArray(n - 1, memo) + FibRecArray(n - 2, memo);

            return memo[n - 1];
        }

        public static long FibRecDictionary(int n, Dictionary<int, long> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<int, long>(n);
            }

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n <= 2)
            {
                memo[n] = 1;
                return 1;
            }

            memo.Add(n, FibRecDictionary(n - 1, memo) + FibRecDictionary(n - 2, memo));

            return memo[n];
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
