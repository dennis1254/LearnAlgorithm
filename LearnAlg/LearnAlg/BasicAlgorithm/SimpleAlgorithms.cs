using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAlg.BasicAlgorithm
{
    public class SimpleAlgorithms
    {
        public const string sampleText1 = "This is a simple algorithm.";
        public static string ReverseString(string txt)
        {
            string newTxt = string.Empty;
            for(int i = txt.Length-1; i >= 0; i--)
            {
                newTxt += txt[i];
            }
            return newTxt;
        }
        public static string ReverseWord(string txt)
        {
            var wordArray = txt.Split(' ');
            string newTxt = string.Empty;
            for (int i = wordArray.Length - 1; i >= 0; i--)
            {
                newTxt += wordArray[i]+" ";
            }
            return newTxt;
        }
        public static bool IsPalindrome(string txt)
        {
            //if instructed to ignore case, txt should be converted to upper or lower case 1st
            for (int i = 0, j= txt.Length - 1; i < txt.Length/2; i++,j--)
            {             
                if (txt[j] != txt[i]) return false;            
            }
            return true;
        }
        public static void FindAllSubstring(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
        public static bool IsPrimeNumber(int number)
        {
            if (number == 1)
                return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static void Execute()
        {

            Console.WriteLine(ReverseWord(sampleText1));
        }
    }
}
