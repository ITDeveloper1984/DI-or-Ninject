using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NinjectDependencyInjection.Interface;

namespace NinjectDependencyInjection
{
    public class WeatherStation:IWeatherStation
    {
        private readonly IDisplay _display;

        public WeatherStation(IDisplay D)
        {
            _display = D;
        }
        public void DisplayReport()
        {
            _display.Read();
        }
    }
}
