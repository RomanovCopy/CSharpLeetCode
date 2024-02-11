using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005LongestPalindromicSubstring
{
    internal class Solution
    {
        string line = "s";
        public Solution()
        {
            Console.WriteLine(LongestPalindrome(line));
            Console.ReadKey();
        }

        public string LongestPalindrome(string s)
        {
            string palindrom = "";
            string substring = "";
            int runer = 0;
            int length = s.Length;
            if (length < 2)
                return s;
            for (int index = 0; index < length; index++)
            {
                if (!char.IsLetterOrDigit(s[index]))
                    continue;
                for (int i = length - 1; i > index; i--)
                {
                    runer = s.IndexOf(s[index], i);
                    if (runer > 0)
                    {
                        substring = s.Substring(index, runer - index + 1);
                        if (IsPalindrom(substring) && substring.Length > palindrom.Length)
                        {
                            palindrom = substring;
                        }
                    }
                    else if (palindrom.Length < s.Substring(index, 1).Length)
                    {
                        palindrom = s.Substring(index, 1);
                    }

                }
            }
            return palindrom;
        }

        private bool IsPalindrom(String word)
        {
            int lenght = word.Length;
            if (lenght > 1)
            {
                int startBegin = 0;
                int endBegin = lenght - 1;
                for (; startBegin < endBegin;)
                {
                    for (; startBegin < endBegin;)
                    {
                            if (!(word[startBegin] == word[endBegin]))
                            {
                                return false;
                            }
                            startBegin++;
                            endBegin--;
                    }
                }

            }
            return true;
        }
    }
}
