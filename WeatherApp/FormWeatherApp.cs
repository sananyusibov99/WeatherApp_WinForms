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
    public partial class FormWeatherApp : Form
    {
        public static int index = 0, test = 0;
        static string sub = null;
        static int iter = 0;
       
        public FormWeatherApp()
        {
            InitializeComponent();
        }
        
        // Единицы измерения
        public void RadioButtonsUnitSet(Options options)
        {
            if (radioButtonCelsius.Checked)
            {
                options.Units = "metric";
            }
            else if (radioButtonFahrenheit.Checked)
            {
                options.Units = "imperial";
            }
            else if (radioButtonKelvin.Checked)
            {
                options.Units = "default";
            }
        }

        public void TemperatureUnits(Options options)
        {
            if (options.Units == "metric")
                txtResult.Text += "°С\n";
            else if (options.Units == "imperial")
                txtResult.Text += "°F\n";
            else
                txtResult.Text += "K\n";
        }

        public void SpeedUnits(Options options)
        {
            if (options.Units == "imperial")
                txtResult.Text += "km/h\n";
            else
                txtResult.Text += "meter/sec\n";
        }

        // Вывод погоды
        public void WeatherToday(JObject data, Options options)
        {
            txtResult.Text = "City: " + (string)data["name"] + '\n';
            txtResult.Text += "Weather Description: " + (string)data["weather"][0]["description"] + '\n';
            txtResult.Text += "Temperature: " + (string)data["main"]["temp"];
            TemperatureUnits(options);
            txtResult.Text += "Minimum temperature: " + (string)data["main"]["temp_min"];
            TemperatureUnits(options);
            txtResult.Text += "Maximum temperature: " + (string)data["main"]["temp_max"];
            TemperatureUnits(options);
            txtResult.Text += "Wind Speed: " + (string)data["wind"]["speed"];
            SpeedUnits(options);
            txtResult.Text += "Cloudiness: " + (string)data["clouds"]["all"] + "%\n";
            txtResult.Text += "Pressure: " + (string)data["main"]["pressure"] + " hPa\n";
            txtResult.Text += "Humidity: " + (string)data["main"]["humidity"] + "%\n";
        }

        public void WeatherTomorrow(JObject data, Options options)
        {
            float min = 99999, max = -99999;

            txtResult.Text = "City: " + (string)data["city"]["name"] + '\n';

            for (int i = 6; i < 13; i++) // Подсчет средней минимальной и максимальной погоды
            {
                if ((int)data["list"][i]["main"]["temp_min"] < min)
                {
                    min = (int)data["list"][i]["main"]["temp_min"];
                }
                if ((int)data["list"][i]["main"]["temp_max"] > max)
                {
                    max = (int)data["list"][i]["main"]["temp_max"];
                }
            }
            txtResult.Text += "Minimum temperature: " + min;
            TemperatureUnits(options);
            txtResult.Text += "Maximum temperature: " + max;
            TemperatureUnits(options);
            txtResult.Text += "\n";

            for (int i = 5; i < 13; i++) // Вывод погоды на завтра по часам
            {
                txtResult.Text += "Weather description: " + (string)data["list"][i]["weather"][0]["description"] + '\n';
                txtResult.Text += "Temperature: " + (string)data["list"][i]["main"]["temp"];
                TemperatureUnits(options);
                txtResult.Text += "Wind Speed: " + (string)data["list"][i]["wind"]["speed"];
                SpeedUnits(options);
                txtResult.Text += "Cloudiness: " + (string)data["list"][i]["clouds"]["all"] + "%\n";
                txtResult.Text += "Pressure: " + (string)data["list"][i]["main"]["pressure"] + " hPa\n";
                txtResult.Text += "Humidity: " + (string)data["list"][i]["main"]["humidity"] + "%\n";
                txtResult.Text += "Date: " + (string)data["list"][i]["dt_txt"] + "\n\n";
            }

        }

        public void WeatherFiveDays(JObject data, Options options)
        {
            txtResult.Text = "City: " + (string)data["city"]["name"] + '\n';

            for (int i = 1; i < 6; i++) // 5 Дней
            {
                DateTime dateValue = DateTime.Now.AddDays(i - 1);
                txtResult.Text += "\t\t\t" + dateValue.DayOfWeek.ToString() + "\n";
                float temperature = 0, windspeed = 0, cloudiness = 0, pressure = 0, humidity = 0, min = 0, max = 0;
                do // Сумма всех показателей (чтобы в дальнейшем найти среднее значение
                {
                    if (index == (int)data["cnt"]) break;
                    label1.Text = (string)data["list"][index]["dt_txt"];
                    String value = label1.Text;
                    Char delimiter = ' ';
                    String[] substrings = value.Split(delimiter);
                    sub = substrings[0];

                    if (sub == $"{DateTime.Now.AddDays(i - 1).ToString("yyyy-MM-dd")}")
                    {
                        temperature += (float)data["list"][index]["main"]["temp"];
                        windspeed += (float)data["list"][index]["wind"]["speed"];
                        cloudiness += (float)data["list"][index]["clouds"]["all"];
                        pressure += (float)data["list"][index]["clouds"]["all"];
                        humidity += (float)data["list"][index]["main"]["humidity"];
                        min += (float)data["list"][index]["main"]["temp_min"];
                        max += (float)data["list"][index]["main"]["temp_max"];

                        //MessageBox.Show($"{DateTime.Now.AddDays(i-1).ToString("yyyy-MM-dd")}");
                        //label1.Text.StartsWith($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}")

                        index++;
                        iter++;
                    }
                } while (sub == $"{DateTime.Now.AddDays(i - 1).ToString("yyyy-MM-dd")}");

                txtResult.Text += "Weather Description: " + (string)data["list"][i]["weather"][0]["description"] + '\n';
                txtResult.Text += "Minimum temperature: " + Math.Round(min / iter,2);
                TemperatureUnits(options);
                txtResult.Text += "Maximum temperature: " + Math.Round(max / iter,2);
                TemperatureUnits(options);
                txtResult.Text += "Wind Speed: " + Math.Round(windspeed / iter,2);
                SpeedUnits(options);
                txtResult.Text += "Cloudiness: " + Math.Round(cloudiness / iter,1) + "%\n";
                txtResult.Text += "Pressure: " + Math.Round(pressure / iter,0) + " hPa\n";
                txtResult.Text += "Humidity: " + Math.Round(humidity / iter,0) + "%\n\n";
               
                iter = 0;

            }
        }

        public void WeatherFiveDaysByHours(JObject data, Options options)
        {
            txtResult.Text = "City: " + (string)data["city"]["name"] + '\n';
            for (int i = 1; i < 6; i++) // 5 дней
            {
                DateTime dateValue = DateTime.Now.AddDays(i - 1);
                txtResult.Text += "\t\t\t" + dateValue.DayOfWeek.ToString() + "\n";
                do
                {
                    if (index == (int)data["cnt"]) break;
                    label1.Text = (string)data["list"][index]["dt_txt"];
                    String value = label1.Text;
                    Char delimiter = ' ';
                    String[] substrings = value.Split(delimiter);
                    sub = substrings[0];

                    if (sub == $"{DateTime.Now.AddDays(i - 1).ToString("yyyy-MM-dd")}")
                    {
                        txtResult.Text += label1.Text + "\n";
                        txtResult.Text += "Weather Description" + (string)data["list"][i]["weather"][0]["description"] + '\n';
                        txtResult.Text += "Temperature: " + (string)data["list"][index]["main"]["temp"];
                        TemperatureUnits(options);
                        txtResult.Text += "Wind Speed: " + (string)data["list"][index]["wind"]["speed"];
                        SpeedUnits(options);
                        txtResult.Text += "Cloudiness: " + (string)data["list"][index]["clouds"]["all"] + "%\n";
                        txtResult.Text += "Pressure: " + (string)data["list"][index]["main"]["pressure"] + " hPa\n";
                        txtResult.Text += "Humidity: " + (string)data["list"][index]["main"]["humidity"] + "%\n\n";

                        //MessageBox.Show(sub);
                        //MessageBox.Show($"{DateTime.Now.AddDays(i-1).ToString("yyyy-MM-dd")}");
                        //label1.Text.StartsWith($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}")

                        index++;

                    }
                } while (sub == $"{DateTime.Now.AddDays(i - 1).ToString("yyyy-MM-dd")}");
            }

        }

        // Кнопки
        private void BtnLocation_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"http://api.ipstack.com/check?access_key=fc3e2a13f4fe42814bff600fac16ac9b");
                var data = JObject.Parse(result);

                txtCityName.Text = (string)data["city"];
            }
        }

        private void BtnTodayWeather_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        Options options = new Options(txtCityName.Text);
                        RadioButtonsUnitSet(options);

                        var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?q={options.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={options.Units}");
                        var data = JObject.Parse(result);

                        WeatherToday(data, options);
                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateOutput();
                }
                catch { }
            }

        }

        private void BtnTomorrowWeather_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        Options options = new Options(txtCityName.Text);
                        RadioButtonsUnitSet(options);

                        var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/forecast?q={options.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={options.Units}");
                        var data = JObject.Parse(result);

                        WeatherTomorrow(data, options);
                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateOutput();
                }
                catch { }
            }
        }

        private void BtnFiveDays_Click(object sender, EventArgs e)
        {
            index = 0;
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        Options options = new Options(txtCityName.Text);
                        RadioButtonsUnitSet(options);

                        var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/forecast?q={options.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={options.Units}");
                        var data = JObject.Parse(result);

                        WeatherFiveDays(data, options);
                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateOutput();
                }
                catch { }
            }
        }

        private void BtnFiveDays_By_Hours_Click(object sender, EventArgs e)
        {
            index = 0;
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        Options options = new Options(txtCityName.Text);
                        RadioButtonsUnitSet(options);

                        var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/forecast?q={options.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={options.Units}");
                        var data = JObject.Parse(result);

                        WeatherFiveDaysByHours(data, options);
                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateOutput();
                }
                catch { }
            }

        }

        // Меню
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var wnd = new FormSettings();
            var res = wnd.ShowDialog();

            WebClient();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
