using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonDenominator
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/common-denominators/train/csharp

            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 }};
            convertFrac(lst);
            Console.ReadLine();
        }


        //convertFracs [(1, 2), (1, 3), (1, 4)] `shouldBe` [(6, 12), (4, 12), (3, 12)]


        public static string convertFrac(long[,] lst)
        {
            List<long> neededNums = new List<long>();

            //Currently this sets up a loop which checks a number against all numbers after it
            for (int i = 0; i < lst.Length / 2; i++)
            {
                neededNums.Add(lst[i, 1]);

                for (int j = 1 + i; j < (lst.Length / 2 ); j++)
                {
                    if (lst[j,1] % lst[i,1] == 0)
                    {
                        neededNums.Remove(lst[i, 1]);
                        break;
                    }
                }
                Console.WriteLine();
            }


            long lCD = neededNums[0];
            for (int i = 1; i < neededNums.Count; i++)
            {
                lCD *= neededNums[i];
            }


            string returnString = "[";
            for (int i = 0; i < lst.Length / 2; i++)
            {
                returnString += ("(" + lCD / lst[i, 1] + ", " + lCD + ")");
                if (i+1 < lst.Length/2)
                {
                    returnString += ", ";
                }
            }
            returnString += "]";

            return returnString;
        }
    }
}
