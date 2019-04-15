using System;
using System.Collections.Generic;
using System.Text;

namespace Composition.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract()
        {
        }

        HourContract(DateTime date, double value, int hour)
        {
            Date = date;
            ValuePerHour = value;
            Hour = hour;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
