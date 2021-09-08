using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConstruct
{
    public static class AllConstructMemoization
    {
        public static IList<IList<string>> AllConstruct(string target, string[] wordBank, Dictionary<string, IList<IList<string>>> memo = null)
        {
            if (memo == null)
            {
                memo = new Dictionary<string, IList<IList<string>>>();
            }

            if (memo.ContainsKey(target))
            {
                return memo[target];
            }

            if (target == "")
            {
                IList<IList<string>> emptyCombination = new List<IList<string>>();
                emptyCombination.Add(new List<string>());

                return emptyCombination;
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string newTarget = target.Substring(word.Length);

                    IList<IList<string>> newTargetCombinations = AllConstruct(newTarget, wordBank, memo);
                    IList<IList<string>> targetCombinations = newTargetCombinations.Select(x => { x.Insert(0, word); return x; }).ToList();

                    foreach (var combination in targetCombinations)
                    {
                        result.Add(new List<string>(combination));
                    }
                }
            }

            memo.Add(target, result);
            return result;
        }
    }
}
