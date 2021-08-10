namespace FictionSnippets.Interfaces
{
    public interface IAnagram
    {
    
         public void IsAnagram(string inputString1,string inputString2);
         public void IsAnagramInShort(string inputString1,string inputString2);
         public void IsAnagramOptimal(string inputString1,string inputString2);
         
    }

  public interface IFibonacci
    {
       public void FindFiboWithIteration(int number);
        public int FindFiboWithRecursion(int n, int val, int prev);
        public void FindFiboWithRecursionMain(int n);
        public void FindFiboOneLinerLinq(int n);
    }

      public interface IFactorial
    {
       public void FindFactorialWithIteration(int number);
        public int FindFactorialWithRecursion(int n);
        public void FindFactorialWithRecursionMain(int n);
        public void FindFactorialOneLinerLinq(int n);
    }


}