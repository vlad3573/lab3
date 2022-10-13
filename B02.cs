using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class B02 : B
    {
        public B02(string country, string city, DateTime cityTime) : base(country, city, cityTime) 
        {
        }
        public override void ShortDate()
        {
            Console.WriteLine($"{city}: {cityTime.ToLongDateString()}");
            Debug.WriteLine($"{country}, {city}, {cityTime}\n");
        }
    }
}
