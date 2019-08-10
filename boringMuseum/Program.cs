using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boringMuseum
{
    class Program
    {

        //One of the alternatives here is that I could sort this thing, and then remove the one at the front

        public static List<int> removeSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                return numbers;
            }
            else {

                int smallestNum = numbers[0];

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] < smallestNum)
                    {
                        smallestNum = numbers[i];
                    }
                }


                Console.WriteLine(smallestNum);

                //change later to return the new list
                return numbers;
            }
        }

        static void Main(string[] args)
        {
            removeSmallest(new List<int> {3, 2, 5, 4});
            Console.ReadLine();
        }
    }
}
