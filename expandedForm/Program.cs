using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expandedForm
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/write-number-in-expanded-form/train/csharp

            //Kata.ExpandedForm(12); # Should return "10 + 2"
            //Kata.ExpandedForm(42); # Should return "40 + 2"
            //Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
            ExpandedForm(70304);
            Console.ReadLine();
        }

        public static string ExpandedForm(long num)
        {
            string returnString = "";
            for (int i = num.ToString().Length - 1; i > -1; i--)
            {
                long configNum = num / Convert.ToInt64(Math.Pow(10, i)) * Convert.ToInt64(Math.Pow(10, i));
                if (configNum > 0)
                {
                    returnString += configNum + " + ";
                }
                num -= (num / Convert.ToInt64(Math.Pow(10, i)) * Convert.ToInt64(Math.Pow(10, i)));

            }
            return returnString.Substring(0, returnString.Length - 3);
        }s
    }
}
