using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanSum
{
    public static class CanSumTabulation
    {
        public static bool CanSum(int targetSum, int[] numbers)
        {
            bool[] table = new bool[targetSum + 1];
            table[0] = true;

            for (int i = 0; i <= targetSum; i++)
            {
                if (table[i])
                {
                    foreach (var num in numbers)
                    {
                        if (i + num <= targetSum)
                        {
                            table[i + num] = true;
                        }
                    }
                }
            }

            return table[targetSum];
        }
    }
}
