using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/fruit-machine/train/csharp

            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel3 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel1, reel2, reel3 };

            //string[] reel = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };


            int[] spins = new int[] { 0, 0, 0 };
            Console.WriteLine(fruit(reels, spins));

            Console.ReadLine();
        }

        public static int fruit(List<string[]> reels, int[] spins)
        {
            List<string> pointList = new List<string> { "Jack", "Queen", "King", "Bar", "Cherry", "Seven", "Shell", "Bell", "Star", "Wild"};

            string firstReel = reels[0][spins[0]];
            string secondReel = reels[0][spins[1]];
            string thirdReel = reels[0][spins[2]];

            int points = 0;

            if ((firstReel == secondReel || secondReel == thirdReel) && firstReel == "Wild" || secondReel == "Wild" || thirdReel == "Wild")
            {
                points = 2 * (pointList.IndexOf(firstReel) + 1);
            }
            else if (firstReel == secondReel && secondReel == thirdReel)
            {
                points = 10*(pointList.IndexOf(firstReel)+1);
            }
            else if (firstReel == secondReel || secondReel == thirdReel)
            {
                points = (pointList.IndexOf(firstReel) + 1);
            }
            

            //Console.WriteLine(firstReel);
            //Console.WriteLine(secondReel);
            //Console.WriteLine(thirdReel);
            //Console.WriteLine();

            return points;
        }

    }
}
