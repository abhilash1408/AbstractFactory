using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class Pulsar : Bike
    {
        public Pulsar(string name, string company) : base(name, company)
        {
            OwnerName = name;
            Company = company;
            Price = 90000;
        }


    }
}
