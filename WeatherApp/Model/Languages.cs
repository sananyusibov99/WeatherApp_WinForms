using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class Languages
    {
        private static string language;
        public static string Language
        {
            get { return language; }
            set { language = value; }
        }
    }
}
