using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortoiseRace
{
    class Program
    {
        public static int[] Race(int v1, int v2, int g)
        {
            double amountAhead = g;
            double returnAmount = (-amountAhead/(v1-v2))*3600;
            Console.WriteLine("returnAmount in seconds: " + returnAmount);

            //if greater than 60 seconds we should divide by 60
                //The funny thing is that I don't think c# cares about whitespace
                Console.WriteLine();

            Console.WriteLine("In the method");
            return null;
        }


        // So the equation would be (v1 * T + headStart) = (v2 * T)
        // (v1 * T) - (v2 * T) + headstart = 0
        // (v1 - v2)T + headstart = 0
        // (v1 - v2)T = -headstart
        // T = -headstart/(v1-v2)

        //(4 * 3) - (6 * 3) -> -6
        //(4 - 6)3 = -6


        static void Main(string[] args)
        {
            Race(720,850,70);
            //This should equal 0,32,18 in some way
            //Indicating the number of hours,minutes, and seconds respectively
            //g is the headstart that the first tortoise has
            //And each amount is denoted by feet per hour
            Console.ReadLine();
        }
    }
}
