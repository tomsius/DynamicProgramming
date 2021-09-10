using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountConstruct
{
    public static class CountConstructTabulation
    {
        public static int CountConstruct(string target, string[] wordBank)
        {
            int[] table = new int[target.Length + 1];
            table[0] = 1;

            for (int i = 0; i < target.Length; i++)
            {
                foreach (var word in wordBank)
                {
                    if (i + word.Length <= target.Length && target.Substring(i, word.Length) == word)
                    {
                        table[i + word.Length] += table[i];
                    }
                }
            }

            return table[target.Length];
        }
    }
}
