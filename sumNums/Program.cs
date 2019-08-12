using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ShowSequence(6));
            Console.ReadLine();


            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
        }

        public static string ShowSequence(int n)
        {
           if (n < 0)
           {
                return n + "<0";
           }
           else if (n == 0)
           {
                return "0=0";
           }
           else
           {
                int returnNum = 0;
                string returnString = "";
                for (int i = 0; i < n+1; i++)
                {
                    returnNum += i;
                    returnString += i;
                    if (i < n)
                    {
                        returnString += "+";
                    }
                }
                return returnString + " = " + returnNum;
           }
        }
    }
}
