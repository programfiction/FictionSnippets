using System;

namespace FictionSnippets.Snippets
{
    public class QuickSort
    {
         public int[] QSort(int[] arr){
             int len=arr.Length, left=0, right=arr.Length-1;
            var arrResult= myQuickSort(arr, left, right);
         return arrResult;
         }
          
        public int[] myQuickSort(int[] arr,int left,int right){
            int pivot;
            if(left<right)
            {
                pivot= GetPivot(arr,left,right);
                if(pivot>1)
                myQuickSort(arr,left,pivot);

                if(pivot+1<right)
                myQuickSort(arr,pivot+1,right);
            }
            return arr;
        }
        public int GetPivot(int[] arr,int left, int right)
        {
            int pivot= arr[left];
            while (true)
            {
                while (pivot>arr[left])
                {
                    left++;
                }
                while (pivot<arr[right])
                {
                    right--;
                }

                if(left<right)
                {
                    int temp= arr[left];
                    arr[left]=arr[right];
                    arr[right]=temp;
                }
                else
                {
                    return right;
                }
            }
        }
    } 
}