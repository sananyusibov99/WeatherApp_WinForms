using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherApp.Presenter;
using WeatherApp.View;

namespace WeatherApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new WeatherPresenter();
            FormWeatherApp view = new FormWeatherApp(presenter);
            WeatherPresenter weatherPresenter = new WeatherPresenter(view);
            weatherPresenter.StartApplication();
            
            //Application.Run(new FormWeatherApp());
        }
    }
}
