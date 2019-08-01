using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kraki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kraki.Controllers
{
        
    [Route("api/hospitals")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        private readonly krakiContext _context;

        public HospitalsController(krakiContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hospital>>> GetkrakiItems()
        {
            return await _context.Hospitals.ToListAsync();
        }


// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Hospital>> GetHospitalItem(int id)
{
    var todoItem = await _context.Hospitals.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    return todoItem;
}
[HttpPost]
public async Task<IActionResult> PostTodoItem(Hospital item)
{
    _context.Hospitals.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutTodoItem(int id, [FromBody] Hospital item)
{
 
item.Id=id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(int id)
{
    var todoItem = await _context.Hospitals.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    _context.Hospitals.Remove(todoItem);
    await _context.SaveChangesAsync();

    return NoContent();
}

    }
}