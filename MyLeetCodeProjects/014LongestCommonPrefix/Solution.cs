using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014LongestCommonPrefix
{
    internal class Solution
    {
        string[ ] array =
        {
            "apple","apricot","apt","application","arch","architect","argue","argument","articulate","artistic"
        };

        char[ ] alphabetArray = new char[ ]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
            'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };

        public Solution ( )
        {
            Console.WriteLine( LongestCommonPrefix( array ));
        }



        public string LongestCommonPrefix ( string[ ] strs )
        {
            string max = "";
            var list = strs.ToList( );
            int i, j, k = 0;
            for( i=0 ;i<list.Count ;i++ )
            {
                for( j=i+1 ;j<list.Count ;j++ )
                {
                    for(k=0 ; k < Math.Min( list[i].Length , list[j].Length ) ;k++ )
                    {
                        if ( !( list[ i ][ k ] == list[ j ][k]) )
                        {
                            break;
                        }
                    }
                }
            }

            return max;
        }
    }
}
