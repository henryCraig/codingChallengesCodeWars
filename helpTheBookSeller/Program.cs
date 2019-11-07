using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpTheBookSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/54dc6f5a224c26032800005c/train/csharp

            string[] art = new string[] { "ABAR 200", "CDXE 500", "BKWR 250", "BTSQ 890", "DRTY 600" };
            String[] cd = new String[] { "A", "B" };

            Console.WriteLine(stockSummary(art, cd));
            Console.ReadLine();
        }



        public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
        {

            if (lstOfArt.Length > 0)
            {
                if (lstOf1stLetter.Length > 0)
                {
                    string returnString = "";
                    for (int i = 0; i < lstOf1stLetter.Length; i++)
                    {
                        int sum = 0;
                        for (int j = 0; j < lstOfArt.Length; j++)
                        {
                            if (lstOfArt[j][0] == lstOf1stLetter[i][0])
                            {
                                Console.WriteLine("found!");
                                String[] callNumSplit = lstOfArt[j].Split(' ');
                                sum += Convert.ToInt32(callNumSplit[1]);
                            }
                        }
                        returnString += "(" + lstOf1stLetter[i] + " : " + sum + ")" + " - ";
                    }
                    return returnString.Substring(0, returnString.Length - 3);
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }

        }
    }
}
