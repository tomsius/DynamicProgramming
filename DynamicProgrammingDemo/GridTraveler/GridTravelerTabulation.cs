using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridTraveler
{
    public static class GridTravelerTabulation
    {
        public static long GridTraveler(int m, int n)
        {
            long[,] table = new long[m + 1, n + 1];
            table[1, 1] = 1;

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    long currentElement = table[i, j];

                    if (i + 1 <= m)
                    {
                        table[i + 1, j] += currentElement; 
                    }

                    if (j + 1 <= n)
                    {
                        table[i, j + 1] += currentElement;
                    }
                }
            }

            return table[m, n];
        }
    }
}
