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
using WeatherApp.Services;
using WeatherApp.Presenter;

namespace WeatherApp.View
{
    public partial class FormWeatherApp : Form
    {
        enum LastFunc { TODAY = 1, TOMORROW, FIVE, FIVEH }
        int Last = 0;
        public static int index = 0, test = 0, labelindex = 0;
        static string sub = null;
        static int iter = 0;
        

        public WeatherPresenter WeatherPresenter { get; set; }

        public void StartApplication()
        {
            Application.Run((Form)this);
        }

        public FormWeatherApp(WeatherPresenter weatherPresenter)
        {
            InitializeComponent();
            WeatherPresenter = weatherPresenter;
            //WeatherPresenter weatherPresenter = new WeatherPresenter();
        }

        // Единицы измерения
        public void RadioButtonsUnitSet()
        {
            if (radioButtonCelsius.Checked)
            {
                Options.Units = "metric";
            }
            else if (radioButtonFahrenheit.Checked)
            {
                Options.Units = "imperial";
            }
            else if (radioButtonKelvin.Checked)
            {
                Options.Units = "default";
            }
        }

        public void TemperatureUnits()
        {
            if (Options.Units == "metric")
                txtResult.Text += " °С\n";
            else if (Options.Units == "imperial")
                txtResult.Text += " °F\n";
            else
                txtResult.Text += " K\n";
        }

        public void TemperatureUnits(Label label)
        {
            if (Options.Units == "metric")
                label.Text += " °С\n";
            else if (Options.Units == "imperial")
                label.Text += " °F\n";
            else
                label.Text += " K\n";
        }

        public void SpeedUnits()
        {
            if (Options.Units == "imperial")
                txtResult.Text += " km/h\n";
            else
                txtResult.Text += " meter/sec\n";
        }

        public void SpeedUnits(Label label)
        {
            if (Options.Units == "imperial")
                label.Text += " km/h\n";
            else
                label.Text += " meter/sec\n";
        }

        // Вывод погоды
        public void WeatherToday()
        {
            WeatherPresenter.TodayWeatherSet();
            txtCityDay.Text = "City: " + WeatherModel.City + '\n';
            DateTime dateValue = DateTime.Now;
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n";
            txtResult.Text = "Weather Description: " + WeatherModel.Description + " \n";
            txtResult.Text += "Temperature: " + WeatherModel.Temperature;
            TemperatureUnits();
            txtResult.Text += "Minimum temperature: " + WeatherModel.MinTemperature;
            TemperatureUnits();
            txtResult.Text += "Maximum temperature: " + WeatherModel.MaxTemperature;
            TemperatureUnits();
            txtResult.Text += "Wind Speed: " + WeatherModel.Speed;
            SpeedUnits();
            txtResult.Text += "Cloudiness: " + WeatherModel.Clouds + " %\n";
            txtResult.Text += "Pressure: " + WeatherModel.Pressure + " hPa\n";
            txtResult.Text += "Humidity: " + WeatherModel.Humidity + " %\n";

            ChangeBackground();
            string picture = WeatherModel.Picture;
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
        }

        public void TomorrowShow()
        {
            txtResult.Text += "Weather description: " + WeatherModel.Description + '\n';
            txtResult.Text += "Temperature: " + WeatherModel.Temperature;
            TemperatureUnits();
            txtResult.Text += "Wind Speed: " + WeatherModel.Speed;
            SpeedUnits();
            txtResult.Text += "Cloudiness: " + WeatherModel.Clouds + " %\n";
            txtResult.Text += "Pressure: " + WeatherModel.Pressure + " hPa\n";
            txtResult.Text += "Humidity: " + WeatherModel.Humidity + " %\n";
            txtResult.Text += "Date: " + WeatherModel.Date + "\n\n";

            ChangeBackground(WeatherModel.TommorowShowIndex);
            string picture = WeatherModel.Picture;
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
        }

        public void WeatherTomorrow()
        {
            txtCityDay.Text = "City: " + WeatherModel.City + '\n';
            DateTime dateValue = DateTime.Now.AddDays(1);
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n";

            txtResult.Text = "Minimum temperature: " + WeatherModel.MinTemperature;
            TemperatureUnits();
            txtResult.Text += "Maximum temperature: " + WeatherModel.MaxTemperature;
            TemperatureUnits();
            txtResult.Text += "\n";

            TomorrowShow();

        }

        public void WeatherFiveDays()
        {
            txtCityDay.Text = "City: " + WeatherModel.City + '\n';
            txtResult.Text = "";

            DateTime dateValue = DateTime.Now.AddDays(WeatherModel.FiveDaysShowIndex - 1);
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n\n";

            float temperature = 0, windspeed = 0, cloudiness = 0, pressure = 0, humidity = 0, min = 0, max = 0;
            do // Сумма всех показателей (чтобы в дальнейшем найти среднее значение)
            {
                //MessageBox.Show(Convert.ToString(WeatherModel.Cnt));
                //MessageBox.Show(Convert.ToString(WeatherModel.IndexFiveDays));

                if (WeatherModel.IndexFiveDays == WeatherModel.Cnt) break;

                label1.Text = WeatherModel.Date;
                String value = label1.Text;
                Char delimiter = ' ';
                String[] substrings = value.Split(delimiter);
                sub = substrings[0];

                if (sub == $"{DateTime.Now.AddDays(WeatherModel.FiveDaysShowIndex - 1).ToString("yyyy-MM-dd")}")
                {
                    WeatherPresenter.FiveDaysWeatherSet();
                    MessageBox.Show("Test"); 
                    temperature += WeatherModel.Temperature;
                    MessageBox.Show("Test2");

                    windspeed += Convert.ToInt64(WeatherModel.Speed);
                    cloudiness += Convert.ToInt64(WeatherModel.Clouds);
                    pressure += Convert.ToInt64(WeatherModel.Pressure);
                    humidity += Convert.ToInt64(WeatherModel.Humidity);
                    min += Convert.ToInt64(WeatherModel.MinTemperature);
                    max += Convert.ToInt64(WeatherModel.MaxTemperature);

                    //MessageBox.Show($"{DateTime.Now.AddDays(i-1).ToString("yyyy-MM-dd")}");
                    //label1.Text.StartsWith($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}")

                    WeatherModel.IndexFiveDays++;
                    iter++;

                }
            } while (sub == $"{DateTime.Now.AddDays(WeatherModel.FiveDaysShowIndex - 1).ToString("yyyy-MM-dd")}");

            txtResult.Text += "Weather Description: " + WeatherModel.Description + '\n';
            txtResult.Text += "Minimum temperature: " + Math.Round(min / iter, 2);
            TemperatureUnits();
            txtResult.Text += "Maximum temperature: " + Math.Round(max / iter, 2);
            TemperatureUnits();
            txtResult.Text += "Wind Speed: " + Math.Round(windspeed / iter, 2);
            SpeedUnits();
            txtResult.Text += "Cloudiness: " + Math.Round(cloudiness / iter, 1) + " %\n";
            txtResult.Text += "Pressure: " + Math.Round(pressure / iter, 0) + " hPa\n";
            txtResult.Text += "Humidity: " + Math.Round(humidity / iter, 0) + " %\n\n";

            ChangeBackground(WeatherModel.FiveDaysShowIndex);
            string picture = WeatherModel.Picture;
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
            iter = 0;

        }

        public void WeatherFiveDaysByHours(JObject data)
        {
            labelindex = 0;
            txtCityDay.Text = "City: " + (string)data["city"]["name"] + '\n';
            txtResult.Text = "";
            txtRes.Text = "";

            DateTime dateValue = DateTime.Now.AddDays(WeatherModel.FiveDaysHShowIndex - 1);
            txtCityDay.Text += dateValue.Day + "." + dateValue.Month.ToString("00") + "." + dateValue.Year + "\n";
            txtCityDay.Text += dateValue.DayOfWeek.ToString() + "\n\n";
            do
            {
                if (index == (int)data["cnt"]) break;
                label1.Text = (string)data["list"][index]["dt_txt"];
                String value = label1.Text;
                Char delimiter = ' ';
                String[] substrings = value.Split(delimiter);
                sub = substrings[0];

                if (sub == $"{DateTime.Now.AddDays(WeatherModel.FiveDaysHShowIndex - 1).ToString("yyyy-MM-dd")}")
                {
                    if (labelindex < 4)
                    {
                        txtResult.Text += label1.Text + "\n";
                        txtResult.Text += "Weather Description: " + (string)data["list"][WeatherModel.FiveDaysHShowIndex]["weather"][0]["description"] + '\n';
                        txtResult.Text += "Temperature: " + (string)data["list"][index]["main"]["temp"];
                        TemperatureUnits();
                        txtResult.Text += "Wind Speed: " + (string)data["list"][index]["wind"]["speed"];
                        SpeedUnits();
                        txtResult.Text += "Cloudiness: " + (string)data["list"][index]["clouds"]["all"] + " %\n";
                        txtResult.Text += "Pressure: " + (string)data["list"][index]["main"]["pressure"] + " hPa\n";
                        txtResult.Text += "Humidity: " + (string)data["list"][index]["main"]["humidity"] + " %\n\n";
                    }
                    else
                    {
                        txtRes.Text += label1.Text + "\n";
                        txtRes.Text += "Weather Description: " + (string)data["list"][WeatherModel.FiveDaysHShowIndex]["weather"][0]["description"] + '\n';
                        txtRes.Text += "Temperature: " + (string)data["list"][index]["main"]["temp"];
                        TemperatureUnits(txtRes);
                        txtRes.Text += "Wind Speed: " + (string)data["list"][index]["wind"]["speed"];
                        SpeedUnits(txtRes);
                        txtRes.Text += "Cloudiness: " + (string)data["list"][index]["clouds"]["all"] + "%\n";
                        txtRes.Text += "Pressure: " + (string)data["list"][index]["main"]["pressure"] + " hPa\n";
                        txtRes.Text += "Humidity: " + (string)data["list"][index]["main"]["humidity"] + "%\n\n";
                    }
                    //MessageBox.Show(sub);
                    //MessageBox.Show($"{DateTime.Now.AddDays(i-1).ToString("yyyy-MM-dd")}");
                    //label1.Text.StartsWith($"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}")

                    index++;
                }
                labelindex++;
            } while (sub == $"{DateTime.Now.AddDays(WeatherModel.FiveDaysHShowIndex - 1).ToString("yyyy-MM-dd")}");

            ChangeBackground(WeatherModel.FiveDaysHShowIndex);
            string picture = (string)data["list"][WeatherModel.FiveDaysHShowIndex]["weather"][0]["icon"];
            pictureBox1.Load($"http://openweathermap.org/img/w/{picture}.png");
        }

        // Кнопки
        private void BtnLocation_Click(object sender, EventArgs e)
        {
            txtCityName.Text = WeatherPresenter.DetermineLocation();
        }

        private void BtnTodayWeather_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 400);

            txtRes.Text = "";

            btnNext.Hide();
            btnPrev.Hide();

            Last = (int)LastFunc.TODAY;
            WeatherModel.TommorowShowIndex = 5; // 5-12
            WeatherModel.FiveDaysShowIndex = 1; // 1-5
            WeatherModel.FiveDaysHShowIndex = 1; // 1-5
            WeatherModel.IndexFiveDays = 0;
            index = 0;

            if (txtCityName.Text.Any())
            {
                try
                {
                    RadioButtonsUnitSet();
                    WeatherModel.City = txtCityName.Text;

                    WeatherPresenter.TodayWeatherSet();
                    WeatherToday();
                }
                catch
                {
                    txtResult.Text = "Incorrect city name";
                }
            }
            else txtResult.Text = "Enter city name";

            try
            {
                TranslateResult();
            }
            catch { }
        }

        private void BtnTomorrowWeather_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 400);

            txtRes.Text = "";
            btnNext.Show();
            btnPrev.Show();
            Last = (int)LastFunc.TOMORROW;
            WeatherModel.FiveDaysShowIndex = 1; // 1-5
            WeatherModel.FiveDaysHShowIndex = 1; // 1-5
            WeatherModel.IndexFiveDays = 0;
            index = 0;

            if (txtCityName.Text.Any())
            {
                try
                {
                    RadioButtonsUnitSet();
                    WeatherModel.City = txtCityName.Text;

                    WeatherModel.MinTemperature = 99999;
                    WeatherModel.MaxTemperature = -99999;
                    WeatherPresenter.TommorowWeatherSet();
                    WeatherTomorrow();
                }
                catch {
                    txtResult.Text = "Incorrect city name";
                }
            }
            else txtResult.Text = "Enter city name";

            try
            {
                TranslateResult();
            }
            catch { }
        }
    
        private void BtnFiveDays_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(500, 400);
            txtRes.Text = "";
            btnNext.Show();
            btnPrev.Show();
            Last = (int)LastFunc.FIVE;
            WeatherModel.TommorowShowIndex = 5; // 5-12
            WeatherModel.FiveDaysHShowIndex = 1; // 1-5
            index = 0;
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        RadioButtonsUnitSet();
                        WeatherModel.City = txtCityName.Text;

                        WeatherModel.MinTemperature = 99999;
                        WeatherModel.MaxTemperature = -99999;
                        WeatherPresenter.FiveDaysWeatherSet();
                        WeatherFiveDays();

                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateResult();
                }
                catch { }
            }
        }

        private void BtnFiveDays_By_Hours_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(600, 630);
            btnNext.Show();
            btnPrev.Show();
            Last = (int)LastFunc.FIVEH;
            WeatherModel.TommorowShowIndex = 5; // 5-12
            WeatherModel.FiveDaysShowIndex = 1; // 1-5
            WeatherModel.IndexFiveDays = 0;
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                if (txtCityName.Text.Any())
                {
                    try
                    {
                        RadioButtonsUnitSet();
                       
                        var result = wc.DownloadString($"http://api.openweathermap.org/data/2.5/forecast?q={WeatherModel.City}&mode=json&APPID=44e4a0d8152c6a9538668064c5c591dc&units={Options.Units}");
                        var data = JObject.Parse(result);

                        WeatherFiveDaysByHours(data);
                    }
                    catch {
                        txtResult.Text = "Incorrect city name";
                    }
                }
                else txtResult.Text = "Enter city name";

                try
                {
                    TranslateResult();
                }
                catch { }
            }
        }

        // Меню
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var wnd = new FormSettings();
                var res = wnd.ShowDialog();
                WebClient();
            }
            catch { }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
             if (Last == 2)
            {
                if (WeatherModel.TommorowShowIndex < 13)
                {
                    WeatherModel.TommorowShowIndex++;
                    BtnTomorrowWeather_Click(sender, e);
                }
            }
            else if (Last == 3)
            {
                if (WeatherModel.FiveDaysShowIndex < 6)
                {
                    WeatherModel.FiveDaysShowIndex++;
                    BtnFiveDays_Click(sender, e);
                }
            }
            else if (Last == 4)
            {
                if (WeatherModel.FiveDaysHShowIndex < 6)
                {
                    WeatherModel.FiveDaysHShowIndex++;
                    BtnFiveDays_By_Hours_Click(sender, e);
                }
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (Last == 2)
            {
                if (WeatherModel.TommorowShowIndex > 5)
                {
                    WeatherModel.TommorowShowIndex--;
                    BtnTomorrowWeather_Click(sender, e);
                }
            }
            else if (Last == 3)
            {
                if (WeatherModel.FiveDaysShowIndex > 1)
                {
                    WeatherModel.FiveDaysShowIndex--;
                    BtnFiveDays_Click(sender, e);
                }
            }
            else if (Last == 4)
            {
                if (WeatherModel.FiveDaysHShowIndex > 1)
                {
                    WeatherModel.FiveDaysHShowIndex--;
                    BtnFiveDays_By_Hours_Click(sender, e);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Background
        public void ChangeBackground()
        {
            foreach (var item in Backgrounds.Thunderstorm)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Thunder;
                    return;
                }
            }
            foreach (var item in Backgrounds.Rain)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Rain;
                    return;
                }
            }
            foreach (var item in Backgrounds.Snow)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Snow;
                    return;
                }
            }
            foreach (var item in Backgrounds.Mist)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Fog;
                    return;
                }
            }
            foreach (var item in Backgrounds.Clouds)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Clouds;
                    return;
                }
            }
            this.BackgroundImage = Properties.Resources.Clear;
            // (string)data["weather"][0]["description"]
        }

        public void ChangeBackground(int Index)
        {
            foreach (var item in Backgrounds.Thunderstorm)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Thunder;
                    return;
                }
            }
            foreach (var item in Backgrounds.Rain)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Rain;
                    return;
                }
            }
            foreach (var item in Backgrounds.Snow)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Snow;
                    return;
                }
            }
            foreach (var item in Backgrounds.Mist)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Fog;
                    return;
                }
            }
            foreach (var item in Backgrounds.Clouds)
            {
                if (item == WeatherModel.Description)
                {
                    this.BackgroundImage = Properties.Resources.Clouds;
                    return;
                }
            }
            this.BackgroundImage = Properties.Resources.Clear;
            //(string)data["list"][Index]["weather"][0]["description"]
        }
        
        // ПЕРЕВОДЧИК
        static List<string> buttons = new List<string>();

        // Замена переведенных кнопок
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
            btnNext.Text = texts[11];
            btnPrev.Text = texts[12];
        }

        // Перевод запросов
        public void TranslateResult()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={txtResult.Text}&lang={Languages.Language}");
                var dat = JObject.Parse(res);
                txtResult.Text = (string)dat["text"][0];

                res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={txtCityDay.Text}&lang={Languages.Language}");
                dat = JObject.Parse(res);
                txtCityDay.Text = (string)dat["text"][0];

                res = wc.DownloadString($"https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20180519T085039Z.2c50b69f58c34887.7d37dc64e412a4142605130cdb6705d8e840df03&%20&text={txtRes.Text}&lang={Languages.Language}");
                dat = JObject.Parse(res);
                txtRes.Text = (string)dat["text"][0];

            }
        }
       
        // Перевод кнопок
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
                    radioButtonKelvin.Text, 
                    btnNext.Text,
                    btnPrev.Text
                };


                for (int item = 0; item < 13; item++)
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
