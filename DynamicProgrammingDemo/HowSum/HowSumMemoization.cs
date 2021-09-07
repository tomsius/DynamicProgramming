using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowSum
{
    public static class HowSumMemoization
    {
        public static IList<int> HowSum(int targetSum, int[] numbers, Dictionary<int, IList<int>> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<int, IList<int>>();
            }

            if (memo.ContainsKey(targetSum))
            {
                return memo[targetSum];
            }

            if (targetSum == 0)
            {
                return new List<int>();
            }

            if (targetSum < 0)
            {
                return null;
            }

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;

                IList<int> remainderResult = HowSum(remainder, numbers, memo);

                if (remainderResult != null)
                {
                    remainderResult.Add(num);
                    memo.Add(targetSum, remainderResult);

                    return memo[targetSum];
                }
            }

            memo[targetSum] = null;
            return null;
        }
    }
}
