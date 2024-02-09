using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    internal class Solution
    {
        public Solution()
        {
            LengthOfLongestSubstring("abcabcbb");
        }

        public int LengthOfLongestSubstring(string s)
        {
            int length = 0;
            string line = "";
            for(int i = 0; i < s.Length; i++)
            {
                line = s[i].ToString();
                for(int j = i; j < s.Length; j++)
                {
                    if (j > i)
                    {
                        if (!line.Contains(s[j]))
                        {
                            line = line + s[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                length = line.Length > length ? line.Length : length;
            }

            return length;
        }




    }
}
