using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 22.5)
                .Operate();
        }
    }
}
