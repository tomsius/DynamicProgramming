using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanConstruct
{
    public static class CanConstructLazy
    {
        public static bool CanConstruct(string target, string[] wordBank)
        {
            if (target == "")
            {
                return true;
            }

            foreach (var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    string newTarget = target.Substring(word.Length);

                    if (CanConstruct(newTarget, wordBank))
                    {
                        return true;
                    }
                    
                }
            }

            return false;
        }

        public static bool CanConstructStringBuilder(string target, string[] wordBank)
        {
            return CanConstructStringBuilder(new StringBuilder(target), wordBank);
        }

        public static bool CanConstructStringBuilder(StringBuilder target, string[] wordBank)
        {
            if (target.Length == 0)
            {
                return true;
            }

            foreach (var word in wordBank)
            {
                if (target.ToString().StartsWith(word))
                {
                    target.Remove(0, word.Length);

                    if (CanConstructStringBuilder(target, wordBank))
                    {
                        return true;
                    }
                    else
                    {
                        target.Insert(0, word);
                    }

                }
            }

            return false;
        }
    }
}
