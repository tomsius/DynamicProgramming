using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConstruct
{
    public static class CountConstructLazy
    {
        public static int CountConstruct(string target, string[] wordBank)
        {
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

                    int numWaysForNewTarget = CountConstruct(newTarget, wordBank);
                    totalCount += numWaysForNewTarget;
                }
            }

            return totalCount;
        }

        public static int CountConstructStringBuilder(string target, string[] wordBank)
        {
            return CountConstructStringBuilder(new StringBuilder(target), wordBank);
        }

        public static int CountConstructStringBuilder(StringBuilder target, string[] wordBank)
        {
            if (target.Length == 0)
            {
                return 1;
            }

            int totalCount = 0;

            foreach (var word in wordBank)
            {
                if (target.ToString().StartsWith(word))
                {
                    target.Remove(0, word.Length);

                    int numWaysForNewTarget = CountConstructStringBuilder(target, wordBank);
                    totalCount += numWaysForNewTarget;

                    target.Insert(0, word);

                }
            }

            return totalCount;
        }
    }
}
