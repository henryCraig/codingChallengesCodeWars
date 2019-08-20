using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fractionToMixedNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            MixedFraction("42/9");
            Console.ReadLine();
        }

        //Input: 42/9, expected result: 4 2/3.
        //Input: 6/3, expedted result: 2.
        //Input: 4/6, expected result: 2/3.
        //Input: 0/18891, expected result: 0.
        //Input: -10/7, expected result: -1 

        public static string MixedFraction(string s)
        {


            Console.WriteLine(5 * Char.GetNumericValue(s[0]));
            Console.WriteLine();
            return s;
        }
    }
}
