using System;
using System.Linq;
using System.Collections.Generic;
using FictionSnippets.Interfaces;

namespace FictionSnippets.Snippets
{
    public class Anagram : IAnagram
    {
        //Method is for standard practic test
        public void IsAnagram(string inputString1,string inputString2){
            try
            {
                
                if(inputString1.Length!=inputString2.Length) Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                
                if(inputString1== null || inputString2 ==null) Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                          
                char[] arrayOne = inputString1.ToLower().ToCharArray();
                char[] arrayTwo = inputString2.ToLower().ToCharArray();
                Array.Sort(arrayOne);
                Array.Sort(arrayTwo);
                string value1 = new string(arrayOne);
                string value2 = new string(arrayTwo);

                if (value1 == value2)Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are Anagram");
                else Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }



        //Mehtod is simple small but slow in performance
         public void IsAnagramInShort(string inputString1,string inputString2){
            try
            {
                if (String.Concat(inputString1.OrderBy(c => c)).Equals(String.Concat(inputString2.OrderBy(c => c)))) Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are Anagram");
                else Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    



        //Method used for optimal & fast result
        public void IsAnagramOptimal(string inputString1, string inputString2)
        {
            try{
                if (inputString1.Length != inputString2.Length)
                {
                Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                }

                var aFrequency = CalculateAppearence(inputString1);
                var bFrequency = CalculateAppearence(inputString2);

                foreach (var key in aFrequency.Keys)
                {
                    if (!bFrequency.ContainsKey(key)) Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                    if (aFrequency[key] != bFrequency[key]) Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are not Anagram");
                }

                Console.WriteLine("Provided string 1: "+inputString1+", string 2:"+inputString2+" are Anagram");
              }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
        private Dictionary<char, int> CalculateAppearence(string input)
        {
            var appearence = new Dictionary<char, int>();
            foreach (var c in input)
            {
                if (!appearence.ContainsKey(c))
                {
                    appearence.Add(c, 0);
                }
                ++appearence[c];
            }
            return appearence;
        }
    }
}