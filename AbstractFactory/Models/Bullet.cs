using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public class Bullet : Bike
    {
        public Bullet(string name, string company) : base(name, company)
        {
            OwnerName = name;
            Company = company;
            Price = 120000;
        }
    }
}
