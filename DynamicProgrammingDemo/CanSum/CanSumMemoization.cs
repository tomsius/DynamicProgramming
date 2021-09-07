using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSum
{
    public static class CanSumMemoization
    {
        public static bool CanSumDictionary(int targetSum, int[] numbers, Dictionary<int, bool> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<int, bool>();
            }

            if (memo.ContainsKey(targetSum))
            {
                return memo[targetSum];
            }

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

                if (CanSumDictionary(remainder, numbers, memo))
                {
                    memo[targetSum] = true;
                    return true;
                }
            }

            memo[targetSum] = false;
            return false;
        }

        public static bool CanSumArray(int targetSum, int[] numbers, int[] memo = null)
        {
            if (memo == null)
            {
                memo = new int[targetSum + 1];
            }

            if (targetSum == 0)
            {
                return true;
            }

            if (targetSum < 0)
            {
                return false;
            }

            if (memo[targetSum] != 0)
            {
                return memo[targetSum] == 1;
            }

            foreach (var num in numbers)
            {
                int remainder = targetSum - num;

                if (CanSumArray(remainder, numbers, memo))
                {
                    memo[targetSum] = 1;
                    return true;
                }
            }

            memo[targetSum] = -1;
            return false;
        }
    }
}
