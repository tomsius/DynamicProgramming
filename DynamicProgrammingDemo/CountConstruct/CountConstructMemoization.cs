using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConstruct
{
    public static class CountConstructMemoization
    {
        public static int CountConstruct(string target, string[] wordBank, Dictionary<string, int> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<string, int>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (target == "")
            {
                return 1;
            }

            int totalCount = 0;

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string newTarget = target.Substring(word.Length);

                    int numWaysForNewTarget = CountConstruct(newTarget, wordBank, memo);
                    totalCount += numWaysForNewTarget;
                }
            }

            memo.Add(target, totalCount);
            return totalCount;
        }
    }
}
