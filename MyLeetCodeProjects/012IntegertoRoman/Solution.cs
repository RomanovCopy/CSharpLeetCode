using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012IntegertoRoman
{
    internal class Solution
    {
        private Dictionary<int , String> intToRoman = new Dictionary<int , string>( )
        {
            {1,"I" }, {2, "II" }, {3,"III" },{4,"IV"},{5,"V"},{6,"VI"},{7,"VII"},{8,"VIII"},
            {9,"IX" },{10,"X"},{50,"L"},{100,"C"},{500,"D"}, {1000,"M"}
        };

        private int[ ] multipliers = { 1000 , 500 , 100 , 50 , 10 , 5, 1 };

        public Solution ( )
        {
            Console.WriteLine( IntToRoman( 56 ) );
        }

        public string IntToRoman ( int num )
        {
            string roman = "";

            

            return roman;
        }


    }
}
