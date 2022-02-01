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
            // ShortestPathAlgo myShortestPath = new ShortestPathAlgo();
            // myShortestPath.FindShortestPathWithDijkstra();

            // QuickSort myObj= new QuickSort();
            LinkedList myll = new LinkedList();
            myll.InsertNext(6);
            myll.InsertNext(7);
            myll.InsertNext(8);
            var result = myll.Traverse(myll);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine("After Reverse");
            myll.Reverse();
            result = myll.Traverse(myll);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.WriteLine("After Reverse");
            myll = myll.Reverse(myll);
            result = myll.Traverse(myll);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
            // var result =myObj.QSort(new int[]{2,1,3});
            // for (int i = 0; i < 3; i++)
            // {
            //     Console.WriteLine(result[i]);
            // }
        }
    }
}
