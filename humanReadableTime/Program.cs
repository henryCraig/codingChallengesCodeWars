using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace humanReadableTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assert.AreEqual("00:01:00", TimeFormat.GetReadableTime(60));
            Console.WriteLine(GetReadableTime(5));
            Console.ReadLine();
        }

        public static string GetReadableTime(int seconds)
        {
            int hours = seconds / 3600;
            seconds -= hours * 3600;
            int minutes = seconds / 60;
            seconds -= minutes * 60;

            string returnHours = (hours < 10) ? ("0" + hours) : hours.ToString();
            string returnMinutes = (minutes < 10) ? ("0" + minutes) : minutes.ToString();
            string returnSeconds = (seconds < 10) ? ("0" + seconds) : seconds.ToString();

            return returnHours + ":" + returnMinutes + ":" + returnSeconds;
        }
    }
}
