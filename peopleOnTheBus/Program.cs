using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleOnTheBus
{
    class Program
    {
        static void Main(string[] args)
        {
            //OK - The first number is the number of people getting on the bus
            //The second number is the number of people getting off the bus

            //So we are just adding one number and then negating the other
            //And then the single number I'm returning is the number of people left on the bus

            //So the first question how do I operate on this thing?
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Console.WriteLine(Number(peopleList));
            Console.ReadLine();
        }

        public static int Number(List<int[]> peopleListInOut)
        {
            int returnNum = 0;
            for (int i = 0; i < peopleListInOut.Count(); i++)
            {
                returnNum += peopleListInOut[i][0];
                returnNum -= peopleListInOut[i][1];
            }
            return returnNum;
        }
    }
}
