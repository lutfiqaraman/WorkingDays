using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysoff = 0;

            //off days are : Friday and Saturday
            string[] daysofweekend = 
            {
                 DayOfWeek.Friday.ToString(),
                 DayOfWeek.Saturday.ToString()
            };

            //1st April 2018
            DateTime startDate = new DateTime(2018, 4, 1);

            //1st May 2018
            DateTime endDate = new DateTime(2018, 5, 1);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (daysofweekend.Contains(date.DayOfWeek.ToString()))
                    daysoff += 1;                
            }

            int totalDays = (int) (endDate - startDate).TotalDays;
            int workingdays = totalDays - daysoff;

            Console.WriteLine("From: " + startDate.ToShortDateString() + " To: " + endDate.ToShortDateString());
            Console.WriteLine("Days : {0}", totalDays);
            Console.WriteLine("Working Days: {0}", workingdays);
            Console.WriteLine("Off Days: {0}", daysoff);

            Console.ReadKey();
        }
    }
}
