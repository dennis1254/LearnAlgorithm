using LearnAlg.LearnEventsAndDelegates;
using System;

namespace LearnAlg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  var y = LeetCode.Reverse(-123);
            //var b = LeetCode.RemoveAnagrams(new[] { "abba", "baba", "bbaa", "cd", "cd" });
            //var a = LeetCode.OrderByOccurrences(new int[] { 1, 2, 3, 4, 5, 6, 4, 4, 3, 3, 6, 6, 6, 6, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, });
            // Console.WriteLine(LearnStringBuilder.StringBuilderExample());

            //var encryted = LearnCryptography.EncryptSymmetric("Owhiroro");
            //Console.WriteLine(encryted);
            //Console.WriteLine(LearnCryptography.DecryptSymmetric(encryted));
            //BasicAlgorithm.SimpleAlgorithms.Execute();
           var c= AlgorithmTechniques.SlidingWindow.MinSubArrayLen(15, new int[] { 5, 1, 3, 5, 10, 7, 4, 9, 2, 8 });

            //EventAndDelegateStartup.Execute();
        
        }
    }
}
