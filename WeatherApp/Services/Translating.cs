using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public static class Translating
    {
        public static string TranslateResult(string Result)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={Result}&lang={Languages.Language}");
                var dat = JObject.Parse(res);
                return (string)dat["text"][0];
            }
        }

        public static string TranslateCityDay(string CityDay)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={CityDay}&lang={Languages.Language}");
                var dat = JObject.Parse(res);
                return (string)dat["text"][0];
            }
        }


        public static string TranslateRes(string Res)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={Res}&lang={Languages.Language}");
                var dat = JObject.Parse(res);
                return (string)dat["text"][0];

            }
        }


    }
}
