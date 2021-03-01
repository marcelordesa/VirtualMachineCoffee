using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VirtualMachineCoffee.App.Shared.Domians.Entities;

namespace VirtualMachineCoffee.App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private readonly List<Coffee> CoffeeOptions = new List<Coffee> { new Coffee(1, "Cappuccino", 3.50M), new Coffee(2, "Mocha", 4.00M), new Coffee(3, "Café com leite", 3.00M) };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CoffeeOptions.ToArray());
        }
    }
}