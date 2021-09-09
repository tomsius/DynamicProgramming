using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciTabulation
    {
        public static long FibSumPreviousElements(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            long[] fib = new long[n + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }

        public static long FibSumForwards(int n)
        {
            long[] table = new long[n + 1];
            table[1] = 1;

            for (int i = 0; i < n - 1; i++)
            {
                table[i + 1] += table[i];
                table[i + 2] += table[i];
            }

            table[^1] += table[^2];

            return table[n];
        }
    }
}
