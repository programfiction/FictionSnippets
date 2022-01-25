using System;
using System.Collections.Generic;
using System.Linq;
using FictionSnippets.Interfaces;

namespace FictionSnippets.Snippets
{
    public class Factorial : IFactorial
    {
        //using loop
        public void FindFactorialWithIteration(int number)
        {
            long result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine (result);
        }

        //using linq
        public void FindFactorialOneLinerLinq(int n)
        {
            Console
                .WriteLine(Enumerable.Range(1, n).Aggregate((f, s) => f * s));
        }

        //using recursion
        public int FindFactorialWithRecursion(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * FindFactorialWithRecursion(n - 1);
        }

        public void FindFactorialWithRecursionMain(int n)
        {
            Console.WriteLine(FindFactorialWithRecursion(n));
        }
    }
}
