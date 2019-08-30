using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theWave
{
    class Program
    {
        static void Main(string[] args)
        {
            wave(" gap ");
            Console.ReadLine();
        }

        public static List<string> wave(string str)
        {
            List<string> returnList = new List<string>();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLetter(str[i]))
                {
                    returnList.Add(str.Substring(0, i).ToLower() + str[i].ToString().ToUpper() + str.Substring(i + 1, str.Length - i - 1));
                }
            }
            return returnList;
        }
    }
}
