using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public abstract class Bike
    {
        public string OwnerName;

        public string Company;




        public string ID { get; set; }
        public int Price;


        protected Bike(string name, string company)
        {
            OwnerName = name;
            Company = company;
        }
    }
}
