using System;
using  FictionSnippets.Snippets;
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

            //calling anagram logic
            Anagram myAnagramObj= new Anagram();
            // myAnagramObj.IsAnagram("AKA","AAK");
            // myAnagramObj.IsAnagramInShort("abcd","dcba");
            // myAnagramObj.IsAnagramOptimal("abcd","dcba");
            //Fibonancci logic
            Fibonacci myFibo= new Fibonacci();
            // myFibo.IsFiboWithIteration(10);
             myFibo.IsFiboWithRecursionMain(10);
        }
    }
}
