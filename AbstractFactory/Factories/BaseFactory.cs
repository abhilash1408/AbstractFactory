using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public abstract class BaseFactory
    {
        public abstract Bike CreateBike(string name, string company);
        public abstract Car CreateCar(string name, string company);
    }
}
