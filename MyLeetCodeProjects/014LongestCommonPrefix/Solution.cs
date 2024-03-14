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
            "ab", "a"
        };

        public Solution ( )
        {
            Console.WriteLine( LongestCommonPrefix( array ));
        }



        public string LongestCommonPrefix ( string[ ] strs )
        {
            if ( strs.Length == 1 )
                return strs[ 0 ];
            string max = "";
            string current = "";
            int minLength = strs[0].Length;
            var set = new HashSet<string>( strs.Length );
            foreach(var item in strs )
            {
                if ( item.Length < minLength )
                    minLength = item.Length;
            }
            for(int i=1 ;i<=minLength ;i++ )//перебор символов в словах
            {
                for(int j=0 ;j<strs.Length ;j++ )//перебор слов
                {
                    current = strs[ j ].Substring( 0 , i );
                    set.Add( current );
                }
                if ( set.Count > 1 )
                {
                    max = current.Remove( current.Length - 1 );
                    break;
                } else
                {
                    max = current;
                    set.Clear( ); }
            }
            return max;
        }
    }
}
