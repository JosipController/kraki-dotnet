using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kraki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kraki.Controllers
{
        
    [Route("api/cities")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly krakiContext _context;

        public CitiesController(krakiContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<City>>> GetkrakiItems()
        {
            return await _context.Cities.ToListAsync();
        }

// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<City>> GetCitiesItems(int id)
{
    var todoItem = await _context.Cities.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    return todoItem;
}
[HttpPost]
public async Task<IActionResult> PostTodoItem([FromBody]City item)
{
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Cities.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutTodoItem(int id, [FromBody] City item)
{
 
item.Id=id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(int id)
{
    var todoItem = await _context.Cities.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    _context.Cities.Remove(todoItem);
    await _context.SaveChangesAsync();

    return NoContent();
}
    }
}