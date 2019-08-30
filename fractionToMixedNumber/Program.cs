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
        //Input: -10/7, expected result: -1 3/7

        public static string MixedFraction(string s)
        {
            string[] factors = s.Split('/');
            int numerator = Int32.Parse(factors[0]);
            int denominator = Int32.Parse(factors[1]);
            Console.WriteLine("numerator: " + numerator);
            Console.WriteLine("Denominator: " + denominator);


            int newNumer = denominator;
            int iter = 0;
            while (newNumer < numerator)
            {
                newNumer += denominator;
                iter++;
            }

            Console.WriteLine("newNumer: " + newNumer);
            Console.WriteLine("iter: " + iter);

            Console.WriteLine("newNumer - numerator: " + Math.Abs((newNumer - numerator) - denominator));



            //Console.WriteLine(Int32.Parse(factors[0]) / Int32.Parse(factors[1]));
            //Console.WriteLine(Int32.Parse(factors[0]) % Int32.Parse(factors[1]));

            return s;
        }

    }
}
