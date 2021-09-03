using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciLazy
    {
        public static int Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
