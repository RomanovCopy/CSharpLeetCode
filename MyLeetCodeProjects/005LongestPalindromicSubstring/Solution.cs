using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005LongestPalindromicSubstring
{
    internal class Solution
    {
        string line = "babad";
        public Solution()
        {
            Console.WriteLine(LongestPalindrome(line));
            Console.ReadKey();
        }

        public string LongestPalindrome(string s)
        {
            string polindrom = "";
            string[] words = s.Split(' ');
            foreach(var word in words)
            {
                string w = word.Trim();
                if (IsPalindrom(w) && w.Length>polindrom.Length)
                    polindrom = w;
            }
            return polindrom;
        }

        private bool IsPalindrom(String word)
        {
            int lenght = word.Length;
            if (lenght > 1)
            {
                int startBegin = 0;
                int endBegin = lenght - 1;
                for (; startBegin<endBegin;)
                {
                    for (; startBegin<endBegin;)
                    {
                        if (!char.IsLetterOrDigit(word[startBegin]))
                        {
                            startBegin++;
                            break;
                        }else if (!char.IsLetterOrDigit(word[endBegin]))
                        {
                            endBegin--;
                            break;
                        }
                        else
                        {
                            if (! (word[startBegin] == word[endBegin]))
                            {
                                return false;
                            }
                                startBegin++;
                                endBegin--;
                        }
                    }
                }

            }
            return true;
        }
    }
}
