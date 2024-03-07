using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013RomanToInteger
{
    internal class Solution
    {
        private readonly Dictionary<string , int> romaNumbersToInteger = new Dictionary<string , int>( )
        {
            {"M",1000 },{"CM",900},{"D",500},{"CD",400},{"C",100},{ "XC",90},{"L",50},{"XL",40},{"X",10},
            {"IX",9 },{"IV",4},{"V",5},{"I",1}

        };

        

        public Solution ( )
        {
            Console.WriteLine( RomanToInt( "MMXXIV" ));
        }

        public int RomanToInt ( string s )
        {
            if(s.Length>0)
            {
                foreach(string key in romaNumbersToInteger.Keys )
                {
                    if ( s.Contains( key )&& s.IndexOf(key)==0 )
                    {
                        s = s.Remove( 0 , key.Length );
                        return romaNumbersToInteger[ key ] + RomanToInt( s );
                    }
                }
            }
            return 0;
        }
    }
}
