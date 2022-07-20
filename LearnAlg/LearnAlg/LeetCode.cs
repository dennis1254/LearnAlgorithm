using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg
{
    public class LeetCode
    {
        public bool IsPalindrome(int x)
        {
            //An integer is a palindrome when it reads the same backward as forward.
            var e = x.ToString();
            if (e[0]!=e[e.Length-1])return false;
            
            int j = e.Length-2;
            for (int i = 1; i < j; i++)
            {
                if(e[i]!=e[j])return false;
                j--;
            }
            return true;


        }
        public bool IsPalindromeInt(int x)
        {
            //An integer is a palindrome when it reads the same backward as forward.
           
            int initial = x;
            int result = 0;
            while (x > 0)
            {
                int remainder = x % 10;
                result = remainder + (result * 10);
                x /= 10;
            }
            return result == initial;

        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode();
            string a = string.Empty;
            string b = string.Empty;
            while (l1.next != null || l2.next!=null)
            {
               if(l1.next != null)
                {
                    a = a + l1.val.ToString();
                    l1=l1.next;
                }
               if (l2.next != null)
                {
                    b = b + l2.val.ToString();                
                    l2=l2.next;
                }
            }
            a = a + l1.val.ToString();
            b = b + l2.val.ToString();
            string c =(int.Parse(a)+int.Parse(b)).ToString();
            result.val=c[c.Length-1];
            for(int i = c.Length-2; i>-1;i--)
            {
                result.next = new ListNode(val:c[i]);
            }
            return result;
        }
        public static int[] OrderByOccurrences(int[] array)
        {
           var result = array.GroupBy(n => n)
                // Order by the frequency of each group of numbers
                .OrderByDescending(g => g.Count())
                // Then by the natural order of each number
                .ThenBy(g => g.Key)
                // Project the groups back to a flat array
                .SelectMany(g => g).ToArray();

            Console.WriteLine(string.Join(",", result));
            // => 1,3,4,2,2
            return result;
        }
        public static IList<string> RemoveAnagrams(string[] words)
        {
            var input = words.ToList();
            for(int i = 0; i < input.Count;)
            {
                var c = input[i];
                var a = c.Distinct();
                var d = input[i + 1];
                var b = d.Distinct();
             
                if (input[i].Length == input[i + 1].Length && a.Count() == b.Count())
                {
                    bool r = false;
                    foreach (char s in a)
                    {
                        if (c.Count(x => x == s) != d.Count((x => x == s)))
                        {
                            r = false;
                            break;
                        }
                        else r = true;
                    }
                    if (r)
                    {
                        input.RemoveAt(i + 1);
                    }
                    else i++;
                }
                else i++;
            }
            return input;
        }
        public static int Reverse(int x)
        {
            var a = x.ToString();
            bool IsNegative = a.Contains('-');
            if (IsNegative)
            {
                a = a.Substring(1);
            }
            string result = string.Empty;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result += a[i];
            }

            try
            {
                int b = Convert.ToInt32(result);
                if (IsNegative)
                {
                    b = b * (-1);
                }
                return b;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        //public static int Reverse(int x)
        //{
           
        //}

    }
    public class ListNode
    {
     public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
  }
}
