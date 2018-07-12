using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    public abstract class Car 
    {



        public string OwnerName;
        public string Company;
        public int Price;
        public string ID { get; set; }

        protected Car(string name, string company)
        {
            this.OwnerName = name;
            this.Company = company;
        }

    }
}
