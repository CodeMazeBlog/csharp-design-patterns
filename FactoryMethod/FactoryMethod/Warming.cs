using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Warming : IAirConditioner
    {
        private readonly double _temperature;

        public Warming(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees.");
        }
    }
}
