using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Data
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options)
            : base(options)
        {
        }

        public DbSet<AbstractFactory.Models.Bike> Bikes { get; set; }
        public DbSet<AbstractFactory.Models.Car> Cars { get; set; }
    }
}
