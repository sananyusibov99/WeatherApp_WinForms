using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class WeatherModel
    {
        public static int Last = 0;

        public static int TommorowShowIndex { get; set; } = 5;
        public static int FiveDaysShowIndex { get; set; } = 1;
        public static int FiveDaysHShowIndex { get; set; } = 1;
        
        public static string City { get; set; }
        public static string Description { get; set; }
        public static float Temperature { get; set; }
        public static float MinTemperature { get; set; }
        public static float MaxTemperature { get; set; }
        public static float Speed { get; set; }
        public static int Clouds { get; set; }
        public static float Pressure { get; set; }
        public static float Humidity { get; set; }
        public static string Picture { get; set; }
        public static string Date { get; set; }

        public static int Index { get; set; }
        public static int IndexFiveDays { get; set; }
        public static int Cnt { get; set; }
    }
}
