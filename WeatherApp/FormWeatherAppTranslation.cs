using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public partial class FormWeatherApp
    {
        static List<string> buttons = new List<string>();

        public void TextChange(List<string> texts)
        {
            settingsToolStripMenuItem.Text = texts[0];
            exitToolStripMenuItem.Text = texts[1];
            lblEnterCity.Text = texts[2];
            btnLocation.Text = texts[3];
            btnToday.Text = texts[4];
            btnTomorrow.Text = texts[5];
            btnFiveDays.Text = texts[6];
            btnFiveDaysH.Text = texts[7];
            radioButtonCelsius.Text = texts[8];
            radioButtonFahrenheit.Text = texts[9];
            radioButtonKelvin.Text = texts[10];


        }

        public void TranslateOutput()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={txtResult.Text}&lang={Languages.Language}");
                var dat = JObject.Parse(res);
                txtResult.Text = (string)dat["text"][0];
            }
        }

        public void WebClient()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;

                buttons = new List<string>
                {
                    settingsToolStripMenuItem.Text,
                    exitToolStripMenuItem.Text,
                    lblEnterCity.Text,
                    btnLocation.Text,
                    btnToday.Text,
                    btnTomorrow.Text,
                    btnFiveDays.Text,
                    btnFiveDaysH.Text,
                    radioButtonCelsius.Text,
                    radioButtonFahrenheit.Text,
                    radioButtonKelvin.Text
                };


                for (int item = 0; item < 9; item++)
                {
                    var result = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={buttons[item]}&lang={Languages.Language}");
                    var data = JObject.Parse(result);
                    buttons[item] = (string)data["text"][0];
                }

                TextChange(buttons);
            }
        }
    }
}
