using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highestScoringWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //"All letters will be lowercase, and all inputs will be valid"

            //"what time are we climbing up to the volcano").Returns("volcano");
            //"take me to semynak").Returns("semynak");
            High("what time are we climbing up to the volcano");
            Console.ReadLine();
        }

        public static string High(string s)
        {
            String[] splitList = s.Split(' ');
            string highestWord = "";
            int highestAmount = 0;

            for (int i = 0; i < splitList.Length; i++)
            {
                int currentAmount = 0;
                for (int j = 0; j < splitList[i].Length; j++)
                {
                    currentAmount += Convert.ToInt32(splitList[i][j]) - 96;
                }
                if (currentAmount > highestAmount)
                {
                    highestAmount = currentAmount;
                    highestWord = splitList[i];
                }
            }
            return highestWord;
        }
    }
}
