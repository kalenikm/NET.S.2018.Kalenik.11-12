using System;
using System.Collections.Generic;
using System.Numerics;

namespace Logic
{
    public static class Fibonacci
    {
        /// <summary>
        /// Returns amount of Fibonacci sequence.
        /// </summary>
        /// <param name="count">Count of numbers in Fibonacci sequence.</param>
        /// <returns>Fibonacci sequence.</returns>
        public static IEnumerable<BigInteger> GetFibonacciSequence(int count)
        {
            if(count <= 0)
                throw new ArgumentException("Count of numbers can't be less than 0.");

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
