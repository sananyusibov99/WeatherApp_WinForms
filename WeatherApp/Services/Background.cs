using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class Background
    {
        public static System.Drawing.Bitmap ChangeBackground()
        {
            foreach (var item in Thunderstorm)
            {
                if (item == WeatherModel.Description)
                {
                    return Properties.Resources.Thunder;
                }
            }
            foreach (var item in Rain)
            {
                if (item == WeatherModel.Description)
                {
                    return Properties.Resources.Rain;
                }
            }
            foreach (var item in Snow)
            {
                if (item == WeatherModel.Description)
                {
                    return Properties.Resources.Snow;
                }
            }
            foreach (var item in Mist)
            {
                if (item == WeatherModel.Description)
                {
                    return Properties.Resources.Fog;
                }
            }
            foreach (var item in Clouds)
            {
                if (item == WeatherModel.Description)
                {
                    return Properties.Resources.Clouds;
                }
            }
            return Properties.Resources.Clear;
            // (string)data["weather"][0]["description"]
        }

        public static List<string> Thunderstorm = new List<string>
            {
                "thunderstorm with light rain",
                "thunderstorm with rain",
                "thunderstorm with heavy rain",
                "light thunderstorm",
                "thunderstorm",
                "heavy thunderstorm",
                "ragged thunderstorm",
                "thunderstorm with light drizzle",
                "thunderstorm with drizzle",
                "thunderstorm with heavy drizzle"
            };

        public static List<string> Rain = new List<string>
        {
            "light intensity drizzle",
            "drizzle",
            "heavy intensity drizzle",
            "light intensity drizzle rain",
            "drizzle rain",
            "heavy intensity drizzle rain",
            "shower rain and drizzle",
            "heavy shower rain and drizzle",
            "shower drizzle",
            //
            "light rain",
            "moderate rain",
            "heavy intensity rain",
            "very heavy rain",
            "extreme rain",
            "freezing rain",
            "light intensity shower rain",
            "shower rain",
            "heavy intensity shower rain",
            "ragged shower rain"
        };

        public static List<string> Snow = new List<string>
        {
            "light snow",
            "snow",
            "heavy snow",
            "sleet",
            "shower sleet",
            "light rain and snow",
            "rain and snow",
            "light shower snow",
            "shower snow",
            "heavy shower snow",
        };

        public static List<string> Mist = new List<string>
        {
            "mist",
            "smoke",
            "haze",
            "sand, dust whirls",
            "fog",
            "sand",
            "dust",
            "volcanic ash",
            "squalls",
            "tornado",
        };

        public static List<string> Clouds = new List<string>
        {
            "few clouds",
            "scattered clouds",
            "broken clouds",
            "overcast clouds",
        };
    }
}
