using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kraki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kraki.Controllers
{
        
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly krakiContext _context;

        public DoctorsController(krakiContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctorItem()
        {
            return await _context.Doctors.ToListAsync();
        }


// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Doctor>> GetDoctorItems(int id)
{
    var todoItem = await _context.Doctors.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    return todoItem;
}
[HttpPost]
public async Task<IActionResult> PostTodoItem(Doctor item)
{
    _context.Doctors.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}
[HttpPut("{id}")]
public async Task<IActionResult> PutTodoItem(int id, [FromBody] Doctor item)
{
 
item.Id=id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(int id)
{
    var todoItem = await _context.Doctors.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    _context.Doctors.Remove(todoItem);
    await _context.SaveChangesAsync();

    return NoContent();
}


    }
}