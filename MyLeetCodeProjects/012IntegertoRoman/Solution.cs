using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012IntegertoRoman
{
    internal class Solution
    {
        private Dictionary<int , String> IntToRoman = new Dictionary<int , string>( )
        {
            {1,"I" }, {2, "II" }, {3,"III" },{4,"IV"},{5,"V"},{6,"VI"},{7,"VII"},{8,"VIII"},
            {9,"IX" },{10,"X"},{50,"L"},{100,"C"},{500,"D"}, {1000,"M"}
        };

        private int[ ] multipliers = { 1000 , 500 , 100 , 50 , 10 , 5, 1 };
        private string roman = "";

        public Solution ( )
        {
            Console.WriteLine( NumToRoman( 44 ) );
        }

        public string NumToRoman ( int num )
        {
            int rest = num;
            while ( rest > 0 )
            {
                foreach(int m in multipliers )
                {
                    int r1 = rest / m;
                    if ( r1 < 1 )
                        continue;
                    roman = CreateRomanNumber( roman , m , r1 );
                    rest -= m * r1;
                    break;
                }
            }

            return roman;
        }

        private bool multiplier(int num, int divider, out int multiplier )
        {
            int res = num / divider;
            multiplier = res > 0 ? res : -1;
            return multiplier > 0;
        }

        private string CreateRomanNumber(string roman, int m, int mult )
        {
            if ( mult < 4 )
            {
                roman += string.Concat( Enumerable.Repeat( IntToRoman[ m ] , mult ) );
            } else
            {
                m = multipliers[ Array.IndexOf( multipliers , m )-1];
                roman+="I"+ string.Concat( Enumerable.Repeat( IntToRoman[ m ] , 1 ) );
            }
            return roman;
        }




    }
}
