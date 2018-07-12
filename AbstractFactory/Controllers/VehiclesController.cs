using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Data;
using AbstractFactory.Factories;
using AbstractFactory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbstractFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly VehicleDbContext _context;
        public VehiclesController(VehicleDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost("A")]
        public async Task<ActionResult<IEnumerable<string>>> PostAsync([FromBody] string name, string company, bool bike)
        {
            Debug.WriteLine("");
            Debug.WriteLine(name + company);
            Debug.WriteLine("");
            BaseFactory factory = new VehicleFactoryA();

            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            
            else if (bike)
            {
                var b = factory.CreateBike(name,company);
                b.Price = b.Price - (b.Price*10 / 100); // 10% DISCOUNT AT factory A

                _context.Bikes.Add(b);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetBike", new { id = b.ID }, b);
            }
            else
            {
                var b = factory.CreateCar(name, company);
                b.Price = b.Price - (b.Price*15 / 100); // 15 % disc at Factory B
                _context.Cars.Add(b);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetCar", new { id = b.ID }, b);
            }
            
        }

    }
}