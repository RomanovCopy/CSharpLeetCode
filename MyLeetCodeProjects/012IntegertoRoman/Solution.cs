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

        private int[ ] multipliers = { 1000 , 500 , 100 , 50 , 10 , 5 , 1 };
        private string roman = "";

        public Solution ( )
        {
            Console.WriteLine( NumToRoman( 90 ) );
        }


        public string NumToRoman ( int num )
        {
            while ( num > 0 )
            {
                foreach ( int num1 in multipliers )
                {
                    int num2 = num / num1;
                    if ( num2 >= 1 )
                    {
                        if ( num2 < 4 )
                        {
                            while ( num2 > 0 )
                            {
                                roman += IntToRoman[ num1 ];
                                num2--;
                                num -= num1;
                            }
                            NumToRoman( num );
                        } else
                        {
                            int num4 = multipliers[ multipliers.ToList<int>( ).IndexOf( num1 ) - 1 ];
                            roman += IntToRoman[ num1] +IntToRoman[ num4];
                            NumToRoman( num );
                        }
                    } else
                        continue;

                }
            }
            return roman;
        }


    }
}
