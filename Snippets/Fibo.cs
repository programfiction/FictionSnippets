using System;
using System.Linq;
using System.Collections.Generic;
using FictionSnippets.Interfaces;

namespace FictionSnippets.Snippets
{
  
   public class Fibonacci : IFibonacci
    {
        //Mehtod is simple n Fast in performance single loop with O(N) performance
        public void IsFiboWithIteration(int number)
        {
            if (number == 0)
            {
              Console.WriteLine(0);
            }
                int result = 1;
                int lastNumber = 0;
                int temp;
                 Console.WriteLine(lastNumber);
                for (int i = 0; i < number; i++)
                {
                    temp = result;
                    result += lastNumber;
                    lastNumber = temp;
                    Console.WriteLine(lastNumber);
                }
          
        }

        public void IsFiboWithRecursionMain(int n)
        {
            Console.WriteLine(IsFiboWithRecursion(10,1,0));
        }
     
        //Mehtod is to find fibonacci with recursion n Fast and O(N) performance
        public  int IsFiboWithRecursion(int n, int val, int prev)
        {
            if (n == 0)
            {
                return prev;
            }
            if (n == 1)
            {
                return val;
            }
            Console.WriteLine(prev);
           return IsFiboWithRecursion(n - 1, val + prev, val);
        }

        
        //using linq expression one liner.       
        public void IsFiboOneLinerLinq(int n)
        {
            List<int> myFibo = new List<int>();
            Enumerable.Range(0,n).ToList().ForEach(x=>  myFibo.Add(x<=1 ?x : myFibo[x-1]+ myFibo[x-2]));

            foreach (var item in myFibo)
            {
                Console.WriteLine(item);
            }
        }
     

    }
}