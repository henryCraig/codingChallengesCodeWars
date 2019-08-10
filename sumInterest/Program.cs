using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateYears(1000.00, .05, .18, 1000.00));
            Console.ReadLine();
        }

        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int numOfYears = 0;
            while (principal < desiredPrincipal)
            {
                principal += (principal * interest - (principal * interest * tax));
                numOfYears += 1;
            }
            return numOfYears;
        }
    }
}
