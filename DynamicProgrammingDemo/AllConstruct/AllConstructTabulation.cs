using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllConstruct
{
    public static class AllConstructTabulation
    {
        public static IList<IList<string>> AllConstructLinqCopy(string target, string[] wordBank)
        {
            List<List<IList<string>>> table = new List<List<IList<string>>>(target.Length + 1);

            for (int i = 0; i < table.Capacity; i++)
            {
                table.Add(new List<IList<string>>());
            }

            table[0].Add(new List<string>());

            for (int i = 0; i < target.Length; i++)
            {
                foreach (var word in wordBank)
                {
                    if (i + word.Length <= target.Length && target.Substring(i, word.Length) == word)
                    {
                        List<IList<string>> newCombinations = new List<IList<string>>(table[i]);
                        newCombinations = newCombinations.Select(x => { IList<string> newList = new List<string>(x); newList.Add(word);  return newList; }).ToList();

                        table[i + word.Length] = new List<IList<string>>(table[i + word.Length]);
                        table[i + word.Length].AddRange(newCombinations);
                    }
                }
            }

            return table[target.Length];
        }

        public static IList<IList<string>> AllConstructManualCopy(string target, string[] wordBank)
        {
            List<List<IList<string>>> table = new List<List<IList<string>>>(target.Length + 1);

            for (int i = 0; i < table.Capacity; i++)
            {
                table.Add(new List<IList<string>>());
            }

            table[0].Add(new List<string>());

            for (int i = 0; i < target.Length; i++)
            {
                foreach (var word in wordBank)
                {
                    if (i + word.Length <= target.Length && target.Substring(i, word.Length) == word)
                    {
                        List<IList<string>> newCombinations = new List<IList<string>>();

                        foreach (var oldCombination in table[i])
                        {
                            IList<string> newCombination = new List<string>(oldCombination);
                            newCombination.Add(word);

                            newCombinations.Add(newCombination);
                        }

                        table[i + word.Length] = new List<IList<string>>(table[i + word.Length]);
                        table[i + word.Length].AddRange(newCombinations);
                    }
                }
            }

            return table[target.Length];
        }
    }
}
