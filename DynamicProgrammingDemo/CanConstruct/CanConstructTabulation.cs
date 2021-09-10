using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanConstruct
{
    public static class CanConstructTabulation
    {
        public static bool CanConstruct(string target, string[] wordBank)
        {
            bool[] table = new bool[target.Length + 1];
            table[0] = true;

            for (int i = 0; i < target.Length; i++)
            {
                if (table[i])
                {
                    foreach (var word in wordBank)
                    {
                        if (i + word.Length <= target.Length && target.Substring(i, word.Length) == word)
                        {
                            table[i + word.Length] = true;
                        }
                    }
                }
            }

            return table[target.Length];
        }
    }
}
