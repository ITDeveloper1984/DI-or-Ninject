using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using NinjectDependencyInjection.Interface;

namespace NinjectDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kernel = new StandardKernel();
            Kernel.Bind<IDisplay>().To<Display>();
            Kernel.Bind<IWeatherStation>().To<WeatherStation>();

            var DisRep = Kernel.Get<IWeatherStation>();
            DisRep.DisplayReport();
        }
    }
}
