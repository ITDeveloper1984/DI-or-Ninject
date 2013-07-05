using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NinjectDependencyInjection.Interface;

namespace NinjectDependencyInjection
{
    public class Display:IDisplay
    {
        public void Read()
        {
            Console.WriteLine("I am inside Display.Read method()");
            Console.ReadLine();
        }
    }
}
