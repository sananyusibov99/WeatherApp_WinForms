using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.View;

namespace WeatherApp.Presenter
{
    public class WeatherPresenter : IWeatherAppPresenter
    {
        private readonly FormWeatherApp _viewWeatherApp;
        private Options _optionsModel;

        //public WeatherPresenter(FormWeatherApp viewWeatherApp)
        //{
        //    _viewWeatherApp = viewWeatherApp;
        //}

        public WeatherPresenter(FormWeatherApp view, Options optionsModel)
        {
            _viewWeatherApp = view;
            _optionsModel = optionsModel;
        }

        public WeatherPresenter()
        {
                
        }

        public void StartApplication()
        {
            _viewWeatherApp.StartApplication();
        }

        public string DetermineLocation()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                var result = wc.DownloadString($"http://api.ipstack.com/check?access_key=fc3e2a13f4fe42814bff600fac16ac9b");
                var data = JObject.Parse(result);

                return (string)data["city"];
            }
        }
    }
}
