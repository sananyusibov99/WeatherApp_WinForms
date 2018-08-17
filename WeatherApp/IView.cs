using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public interface IView
    {
        // общие методы для всех представлений
        void Show();
        void Close();
    }
}
