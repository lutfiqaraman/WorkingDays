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
            int Daysoff = 0;
            int Days = 0;
            int WorkingDays = 0;

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
                Days += 1;

                if (daysofweekend.Contains(date.DayOfWeek.ToString()))
                    Daysoff += 1;
                
            }

            WorkingDays = Days - Daysoff;

            Console.WriteLine("From: " + startDate.ToShortDateString() + " To: " + endDate.ToShortDateString());
            Console.WriteLine("Days : {0}", Days);
            Console.WriteLine("Working Days: {0}", WorkingDays);
            Console.WriteLine("Off Days: {0}", Daysoff);

            Console.ReadKey();
        }
    }
}