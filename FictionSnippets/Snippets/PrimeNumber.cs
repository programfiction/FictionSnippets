using System;
using System.Linq;
using FictionSnippets.Interfaces;

namespace FictionSnippets.Snippets
{
    public class PrimeNumber : IPrime
    {
        //primenumber logic with linq
        public void IsPrimeOneLinerLinq(int n)
        {
            var result =
                Enumerable
                    .Range(2, n)
                    .Where(x => n % x == 0 && n != x)
                    .Select(x => x)
                    .ToArray();
            Console.WriteLine(n + " is Prime? Answer-" + (result.Length == 0));
        }

        //prime number with iteration
        public void IsPrimeWithIteration(int n)
        {
            int flag = 0;
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            Console.WriteLine(n + " is Prime? Answer-" + (flag == 0));
        }

        //Prime number using recursion
        public int IsPrimeWithRecursion(int n, int i)
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                if (n % i == 0)
                    return 0;
                else
                    return IsPrimeWithRecursion(n, i - 1);
            }
        }

        public void IsPrimeWithRecursionMain(int n)
        {
            Console
                .WriteLine(n +
                " is Prime? Answer-" +
                (IsPrimeWithRecursion(n, n / 2) == 0));
        }
    }
}
