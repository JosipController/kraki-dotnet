using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kraki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kraki.Controllers
{
        
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly krakiContext _context;

        public AppointmentsController(krakiContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetkrakiItems()
        {
            return await _context.Appointments.ToListAsync();
        }


// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Appointment>> GetAppointmentItems(int id)
{
    var todoItem = await _context.Appointments.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    return todoItem;
}
[HttpPost]
public async Task<IActionResult> PostTodoItem([FromBody]Appointment item)
{
    _context.Appointments.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutTodoItem(int id, [FromBody] Appointment item)
{
 
item.Id=id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(int id)
{
    var todoItem = await _context.Appointments.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    _context.Appointments.Remove(todoItem);
    await _context.SaveChangesAsync();

    return NoContent();
}


    }
}