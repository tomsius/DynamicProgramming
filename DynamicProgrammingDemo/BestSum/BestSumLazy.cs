using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSum
{
    public static class BestSumLazy
    {
        public static IList<int> BestSum(int targetSum, int[] numbers)
        {
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

                IList<int> remainderResult = BestSum(remainder, numbers);

                if (remainderResult != null)
                {
                    remainderResult.Add(num);

                    if (shortestResult == null|| remainderResult.Count < shortestResult.Count)
                    {
                        shortestResult = remainderResult;
                    }
                }
            }

            return shortestResult;
        }
    }
}
