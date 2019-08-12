using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printerError
{
    class Program
    {
        static void Main(string[] args)
        {
            //"aaabbbbhaijjjm"
            //"aaaxbbbbyyhwawiwjjjwwm"
            Console.WriteLine(PrinterError("aaabbbbhaijjjm"));
            Console.ReadLine();
        }

        public static string PrinterError(String s)
        {
            int counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!(Char.ToLower(s[i]) >= 'a' && Char.ToLower(s[i]) <= 'm'))
                {
                    counter++;
                }
            }
            return counter.ToString() + "/" + s.Length.ToString();
        }
    }
}
