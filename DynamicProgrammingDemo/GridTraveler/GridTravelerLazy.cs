using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridTraveler
{
    public static class GridTravelerLazy
    {
        public static int GridTraveler(int m, int n)
        {
            if (m == 1 && n == 1)
            {
                return 1;
            }

            if (m == 0 || n == 0)
            {
                return 0;
            }

            return GridTraveler(m - 1, n) + GridTraveler(m, n - 1);
        }
    }
}
