using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/stack")]
    [ApiController]
    public class StackController : ControllerBase
    {

        private readonly ApplicationDBContext _context;
        public StackController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var stocks = _context.Stock.ToList();

            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.Stock.Find(id);

            if (stock == null)
            {
                return NotFound(); 
            }

            return Ok(stock);
        }
    }
}
