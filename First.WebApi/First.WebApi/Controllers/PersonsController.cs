using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.WebApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace First.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private PersonContext _context;
        public PersonsController(PersonContext context)
        {
            _context = context;
        }
        //Get işlemi.
        [HttpGet]
        public async Task<IActionResult> GetPerson()
        {
            var getPerson = await _context.Person.ToListAsync();
            return Ok(getPerson);
        }
        //İd'ye göre Get İşlemi.
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdPerson(int id)
        {
            var ıdPerson = await _context.Person.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(ıdPerson);
        }
    }
}