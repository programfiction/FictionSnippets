using System;
using FictionSnippets.Snippets;

namespace FictionSnippets
{
    class ProgramFiction
    {
        protected ProgramFiction()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello ProgramFiction");

            // //calling anagram logic
            // Console.WriteLine("Hello Anagram");
            // Anagram myAnagramObj = new Anagram();
            // myAnagramObj.IsAnagram("AKA","AAK");
            // myAnagramObj.IsAnagramInShort("abcd","dcba");
            // myAnagramObj.IsAnagramOptimal("abcd","dcba");
            
            // //Fibonancci logic
            // Console.WriteLine("Hello Fibonancci");
            // Fibonacci myFibo = new Fibonacci();
            // myFibo.FindFiboWithIteration(10);
            // myFibo.FindFiboWithRecursionMain(10);
            // myFibo.FindFiboOneLinerLinq(10);
            
            // //Factorial logic
            // Console.WriteLine("Hello Factorial");
            // Factorial myFact = new Factorial();
            // myFact.FindFactorialWithIteration(5);
            // myFact.FindFactorialWithRecursionMain(5);
            // myFact.FindFactorialOneLinerLinq(6);

            // //Primenumber
            // PrimeNumber myPrime= new PrimeNumber();
            // myPrime.IsPrimeOneLinerLinq(13);
            // myPrime.IsPrimeWithRecursionMain(9);
            // myPrime.IsPrimeWithIteration(144);
            //Shortest path algorithem
           ShortestPathAlgo myShortestPath= new  ShortestPathAlgo();
           myShortestPath.FindShortestPathWithDijkstra();
        }
    }
}
