using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equalArraySides
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            int[] array2 = new int[] { 1,100,50,-51,1,1};

            Console.WriteLine(FindEvenIndex(array2));
            Console.ReadLine();
        }

        public static int FindEvenIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int rightSide = 0;
                for (int j = 0+1+i; j < arr.Length; j++)
                {
                    rightSide += arr[j];
                }
                int leftSide = 0;

                for (int m = i-1; m > -1; m--)
                {
                    leftSide += arr[m];
                }

                if (rightSide == leftSide)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
