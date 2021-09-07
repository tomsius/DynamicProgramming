using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowSum
{
    public static class HowSumLazy
    {
        public static IList<int> HowSum(int targetSum, int[] numbers)
        {
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

                IList<int> remainderResult = HowSum(remainder, numbers);

                if (remainderResult != null)
                {
                    remainderResult.Add(num);
                    return remainderResult;
                }
            }

            return null;
        }
    }
}
