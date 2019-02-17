using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temperature);
    }
}
