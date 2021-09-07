using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSum
{
    public static class BestSumMemoization
    {
        public static IList<int> BestSum(int targetSum, int[] numbers, Dictionary<int, IList<int>> memo = null)
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

            IList<int> shortestResult = null;

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;

                IList<int> remainderResult = BestSum(remainder, numbers, memo);

                if (remainderResult != null)
                {
                    IList<int> remainderResultCopy = new List<int>(remainderResult);
                    remainderResultCopy.Add(num);

                    if (shortestResult == null || remainderResultCopy.Count < shortestResult.Count)
                    {
                        shortestResult = remainderResultCopy;
                    }
                }
            }

            memo.Add(targetSum, shortestResult);

            return shortestResult;
        }
    }
}
