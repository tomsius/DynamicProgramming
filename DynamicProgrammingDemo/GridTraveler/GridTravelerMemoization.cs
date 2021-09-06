using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridTraveler
{
    public static class GridTravelerMemoization
    {
        public static long GridTraveler(int m, int n, Dictionary<string, long> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<string, long>();
            }

            string key = $"{m},{n}";

            if (memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (m == 1 && n == 1)
            {
                return 1;
            }

            if (m == 0 || n == 0)
            {
                return 0;
            }

            memo.Add(key, GridTraveler(m - 1, n, memo) + GridTraveler(m, n - 1, memo));

            return memo[key];
        }
    }
}
