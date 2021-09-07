using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSum
{
    public static class CanSumLazy
    {
        public static bool CanSum(int targetSum, int[] numbers)
        {
            if (targetSum == 0)
            {
                return true;
            }

            if (targetSum < 0)
            {
                return false;
            }

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;

                if (CanSum(remainder, numbers))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
