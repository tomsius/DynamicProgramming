using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSum
{
    public static class BestSumTabulation
    {
        public static IList<int> BestSum(int targetSum, int[] numbers)
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
                            List<int> newCombination = new List<int>(table[i]);
                            newCombination.Add(num);

                            if (table[i + num] == null || newCombination.Count < table[i + num].Count)
                            {
                                table[i + num] = newCombination;
                            }
                        }
                    }
                }
            }

            return table[targetSum];
        }
    }
}
