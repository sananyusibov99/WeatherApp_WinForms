using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Options
    {
        public string City { get; set; }
        public string Units { get; set; }

        public Options(string City)
        {
            this.City = City;
        }

        public Options() { }
    }
}
