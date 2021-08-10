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
       public void IsFiboWithIteration(int number);
        public int IsFiboWithRecursion(int n, int val, int prev);
        public void IsFiboWithRecursionMain(int n);
    }

}