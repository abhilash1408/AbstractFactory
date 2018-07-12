using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class City : Car
    {
        public City(string name, string company) : base(name, company)
        {
            OwnerName = name;
            Company = company;
            Price = 1000000;
        }
    }
}
