using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConstruct
{
    public static class AllConstructLazy
    {
        public static IList<IList<string>> AllConstruct(string target, string[] wordBank)
        {
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

                    IList<IList<string>> newTargetCombinations = AllConstruct(newTarget, wordBank);
                    IList<IList<string>> targetCombinations = newTargetCombinations.Select(x => { x.Insert(0, word); return x; }).ToList();

                    foreach (var combination in targetCombinations)
                    {
                        result.Add(new List<string>(combination));
                    }
                }
            }

            return result;
        }

        public static IList<IList<string>> AllConstructStringBuilder(string target, string[] wordBank)
        {
            return CountConstructStringBuilder(new StringBuilder(target), wordBank);
        }

        public static IList<IList<string>> CountConstructStringBuilder(StringBuilder target, string[] wordBank)
        {
            if (target.Length == 0)
            {
                IList<IList<string>> emptyCombination = new List<IList<string>>();
                emptyCombination.Add(new List<string>());

                return emptyCombination;
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (var word in wordBank)
            {
                if (target.ToString().StartsWith(word))
                {
                    target.Remove(0, word.Length);

                    IList<IList<string>> newTargetCombinations = CountConstructStringBuilder(target, wordBank);
                    IList<IList<string>> targetCombinations = newTargetCombinations.Select(x => { x.Insert(0, word); return x; }).ToList();

                    foreach (var combination in targetCombinations)
                    {
                        result.Add(new List<string>(combination));
                    }

                    target.Insert(0, word);

                }
            }

            return result;
        }
    }
}
