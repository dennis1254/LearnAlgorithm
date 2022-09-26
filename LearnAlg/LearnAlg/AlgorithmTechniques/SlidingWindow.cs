using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.AlgorithmTechniques
{
    public class SlidingWindow
    {
        //      Applying sliding window technique : 

        //We compute the sum of first k elements out of n terms using a linear loop and store the sum in variable window_sum.
        //Then we will graze linearly over the array till it reaches the end and simultaneously keep track of maximum sum.
        //To get the current sum of block of k elements just subtract the first element from the previous block and add the last element of the current block .

        // Returns maximum sum in
        // a subarray of size k.
        static int maxSum(int[] arr, int n, int k)
        {

            // n must be greater
            if (n < k)
            {
                Console.WriteLine("Invalid");
                return -1;
            }

            // Compute sum of first window of size k
            int max_sum = 0;
            for (int i = 0; i < k; i++)
                max_sum += arr[i];

            // Compute sums of remaining windows by
            // removing first element of previous
            // window and adding last element of
            // current window.
            int window_sum = max_sum;
            for (int i = k; i < n; i++)
            {
                window_sum += arr[i] - arr[i - k];
                max_sum = Math.Max(max_sum, window_sum);
            }

            return max_sum;
        }

        public int LengthOfLongestSubstring(string s)
        {
            int longest = 0;
            string longestSubstring = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (longestSubstring.Contains(s[i]))
                {
                    if(longestSubstring.Length>longest) longest = longestSubstring.Length;
                    longestSubstring = longestSubstring.Substring(longestSubstring.IndexOf(s[i])+1);
                }
                longestSubstring +=s[i];
            }
            if (longestSubstring.Length > longest) longest = longestSubstring.Length;

            return longest;
        }
        //public static int MinSubArrayLen(int target, int[] nums)
        //{
        //    int minCount = 0;
        //    int sum = 0;

        //    foreach (int a in nums)
        //    {
        //        sum += a;
        //        minCount++;
        //        if (sum >= target) break;
        //    }
        //    if (sum < target) return 0;
        //    if (minCount == 1) return minCount;
        //    int result = minCount;
        //    for(int i= 0; i<nums.Length; i++)
        //    {
        //        if(nums.Skip(i).Take(minCount-1).Sum()>= target)
        //        {
        //            result = minCount - 1;
        //            minCount--;
        //        }
        //    }
        //    return result;
        //}
        public static int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Sum() < target) return 0;
            int minLength = nums.Length;
            int sum = 0;
            int lastSum = 0;
            int left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                while (sum >= target)
                {
                    lastSum = sum;
                    sum -= nums[left];
                    left++;
                }
                minLength = lastSum >= target && (i - left + 2 > 0) ? Math.Min(minLength, i - left + 2) : minLength;
            }
            return lastSum>=target? minLength:0;
        }
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var temp = new HashSet<string>();
            var result = new HashSet<string>();
            if (s.Length < 10) return result.ToList();
            for (int j = 10, i = 0; i + 10 <= s.Length; i++)
            {
                var nextSequence = s.Substring(i, j);
                if (temp.Contains(nextSequence))
                {
                    result.Add(nextSequence);
                }
                else
                    temp.Add(nextSequence);
            }
            return result.ToList();
        }
    }
}
