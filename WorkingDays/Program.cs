using System;
using System.Collections.Generic;
using System.Globalization;
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
            DateTime startDate = DateTime.MinValue, endDate = DateTime.MaxValue;

            string format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            CultureInfo culture = new CultureInfo("pt-BR");

            //off days are : Friday and Saturday
            string[] daysofweekend = 
            {
                 DayOfWeek.Friday.ToString(),
                 DayOfWeek.Saturday.ToString()
            };

            //Input start date
            Console.WriteLine("Please input start date (format - dd/mm/yyyy): ");
            string inputstartdate = Console.ReadLine();

            //Input end date
            Console.WriteLine("Please input end date (format - dd/mm/yyyy): ");
            string inputenddate = Console.ReadLine();

            //Check the format of start date
            try
            {
                startDate = DateTime.ParseExact(inputstartdate, format, provider);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", startDate);
            }

            //Check the format of end date
            try
            {
                endDate = DateTime.ParseExact(inputenddate, format, provider);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", endDate);
            }

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                Days += 1;

                if (daysofweekend.Contains(date.DayOfWeek.ToString()))
                    Daysoff += 1;    
            }

            WorkingDays = Days - Daysoff;

            Console.WriteLine();
            Console.WriteLine("From: " + startDate.ToString("d", culture) + " To: " + endDate.ToString("d", culture));
            Console.WriteLine("Days : {0}", Days);
            Console.WriteLine("Working Days: {0}", WorkingDays);
            Console.WriteLine("Off Days: {0}", Daysoff);

            Console.ReadKey();
        }
    }
}