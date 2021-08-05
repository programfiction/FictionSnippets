using System;
using  FictionSnippets.Snippets;
namespace TEST1
{
    class Program
    {
        protected Program()
        {

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ProgramFiction");

            //calling anagram logic
            Anagram myAnagramObj= new Anagram();
            // myAnagramObj.IsAnagram("AKA","AAK");
            // myAnagramObj.IsAnagramInShort("abcd","dcba");
            myAnagramObj.IsAnagramOptimal("abcd","dcba");
        }
    }
}
