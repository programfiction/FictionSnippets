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

      public interface IPrime
    {
       public void IsPrimeWithIteration(int number);
        public int  IsPrimeWithRecursion(int n,int i);
        public void  IsPrimeWithRecursionMain(int n);
        public void  IsPrimeOneLinerLinq(int n);
    }

    public interface IShortestpath
    {
    public void FindShortestPathWithDijkstra();
    public  void PrintShortestPath(int[] dist, int n,int destination);
    public  int FindMinimumDistance(int[] dist,bool[] sptSet);
    }
}