using System;
using System.Collections.Generic;
using System.Linq;

namespace laba3_program3
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Month> MonthList = CreateList();

            Console.WriteLine("All month: ");
            foreach (Month m in MonthList)
                Console.WriteLine(m.month_type);

            //LINQ
            IEnumerable<Month> query = MonthList.Where(m => m.days == 30);

            Console.WriteLine("\nMonth-30days:");
            foreach (Month m in query)
               Console.WriteLine(m.month_type);
        }
 
        public static List<Month> CreateList()
        {
            return new List<Month>
            {
                {new Month(Month.Type.January,31)},
                {new Month(Month.Type.February,28)},
                {new Month(Month.Type.March,31)},
                {new Month(Month.Type.April,30)},
                {new Month(Month.Type.May,31)},
                {new Month(Month.Type.June,30)},
                {new Month(Month.Type.July,31)},
                {new Month(Month.Type.August,31)},
                {new Month(Month.Type.September,30)},
                {new Month(Month.Type.October,31)},
                {new Month(Month.Type.November,30)},
                {new Month(Month.Type.December,31)},
                
            };
        }
    }
}