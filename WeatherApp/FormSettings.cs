using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class FormSettings : Form
    {
        Dictionary<string, string> languages = new Dictionary<string, string>();

        public FormSettings()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&ui=en");
                var data = JObject.Parse(result);
                List<string> list = new List<string>();
                foreach (var item in data["langs"])
                {
                    String value = item.ToString();
                    Char delimiter = ' ';
                    String[] substrings = value.Split(delimiter);
                    string sub1 = substrings[0];
                    sub1 = sub1.Replace("\"", "");
                    sub1 = sub1.Replace(":", "");

                    string sub2 = substrings[1];
                    sub2 = sub2.Replace("\"", "");

                    languages.Add(sub2, sub1);
                    list.Add(sub2);
                }
                comboBox1.DataSource = list;

                // Список языков
                //https://translate.yandex.net/api/v1.5/tr.json/getLangs?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&ui=en
                // Определение языка
                // https://translate.yandex.net/api/v1.5/tr.json/detect?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text=ntrcn
                // Запрос на перевод
                // https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text=%D1%82%D0%B5%D1%81%D1%82&lang=en
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            Languages.Language = languages[comboBox1.Text];
            Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
