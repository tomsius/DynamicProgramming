using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowSum
{
    public static class HowSumTabulation
    {
        public static IList<int> HowSum(int targetSum, int[] numbers)
        {
            List<List<int>> table = Enumerable.Repeat<List<int>>(null, targetSum + 1).ToList();
            table[0] = new List<int>();

            for (int i = 0; i <= targetSum; i++)
            {
                if (table[i] != null)
                {
                    foreach (var num in numbers)
                    {
                        if (i + num <= targetSum)
                        {
                            table[i + num] = new List<int>(table[i]);
                            table[i + num].Add(num);
                        }
                    }
                }
            }

            return table[targetSum];
        }
    }
}
