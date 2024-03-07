using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012IntegertoRoman
{
    internal class Solution
    {
        private readonly Dictionary<int , string> romanNumerals = new Dictionary<int , string>
        {
            { 1000, "M" }, { 900, "CM" },{ 500, "D" },{ 400, "CD" },{ 100, "C" },{ 90, "XC" },
            { 50, "L" },{ 40, "XL" },{ 10, "X" },{ 9, "IX" },{ 5, "V" },{ 4, "IV" },{ 1, "I" }
        };

        public Solution ( )
        {
            Console.WriteLine( IntToRoman( 2024 ) );
            Console.WriteLine( IntToRoman2( 2024 ) );
        }



        private string IntToRoman ( int num )
        {
            if ( num < 1 )
                return "";
            if ( num >= 1000 )
                return "M" + IntToRoman( num - 1000 );
            if ( num >= 900 )
                return "CM" + IntToRoman( num - 900 );
            if ( num >= 500 )
                return "D" + IntToRoman( num - 500 );
            if ( num >= 400 )
                return "CD" + IntToRoman( num - 400 );
            if ( num >= 100 )
                return "C" + IntToRoman( num - 100 );
            if ( num >= 90 )
                return "XC" + IntToRoman( num - 90 );
            if ( num >= 50 )
                return "L" + IntToRoman( num - 50 );
            if ( num >= 40 )
                return "XL" + IntToRoman( num - 40 );
            if ( num >= 10 )
                return "X" + IntToRoman( num - 10 );
            if ( num >= 9 )
                return "IX" + IntToRoman( num - 9 );
            if ( num >= 5 )
                return "V" + IntToRoman( num - 5 );
            if ( num >= 4 )
                return "IV" + IntToRoman( num - 4 );
            if ( num >= 1 )
                return "I" + IntToRoman( num - 1 );
            throw new ArgumentOutOfRangeException( "Ошибка ввода. Число должно быть в интервале 1 до 3999" );
        }


        private string IntToRoman2 ( int num )
        {
            if ( num < 4000 || num > 0 )
            {
                foreach ( var entry in romanNumerals )
                {
                    if ( num >= entry.Key )
                    {
                        return entry.Value + IntToRoman2( num - entry.Key );
                    }
                }
            }
            return "";
        }
    }

}
