using System.Collections.Generic;
using System.Numerics;

namespace Logic
{
    public static class Fibonacci
    {
        public static IEnumerable<BigInteger> GetFibonacciSequence(int count)
        {
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger next;

            for (int i = 0; i < count; i++)
            {
                next = first + second;

                yield return next;

                first = second;
                second = next;
            }
        }
    }
}
