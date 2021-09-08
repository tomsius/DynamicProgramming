using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanConstruct
{
    public static class CanConstructMemoization
    {
        public static bool CanConstruct(string target, string[] wordBank, Dictionary<string, bool> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<string, bool>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (target == "")
            {
                return true;
            }

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string newTarget = target.Substring(word.Length);

                    if (CanConstruct(newTarget, wordBank, memo))
                    {
                        memo.Add(target, true);
                        return true;
                    }

                }
            }

            memo.Add(target, false);
            return false;
        }
    }
}
