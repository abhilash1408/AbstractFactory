using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public class VehicleFactoryA : BaseFactory
    {
        public override Bike CreateBike(string name, string company)
        {
            return new Pulsar( name,  company  );
        }

        public override Car CreateCar(string name,string company)
        {
            return new City( name,  company  );
        }
    }
}
