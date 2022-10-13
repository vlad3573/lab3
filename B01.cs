using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class B01 : B
    {
        public B01(string country, string city, DateTime cityTime) : base(country, city, cityTime) 
        {
        }
        public override void LongDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToUniversalTime()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
