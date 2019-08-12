using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countStringChars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Count("aba"));
            Console.ReadLine();
        }

        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> charsDict = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (charsDict.ContainsKey(str[i]))
                {
                    charsDict[str[i]] += 1;
                }
                else
                {
                    charsDict.Add(str[i], 1);
                }
            }
            return charsDict;
        }
    }
}
