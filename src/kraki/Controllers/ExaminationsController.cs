using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kraki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace kraki.Controllers
{
        
    [Route("api/examinations")]
    [ApiController]
    public class ExaminationsController : ControllerBase
    {
        private readonly krakiContext _context;

        public ExaminationsController(krakiContext context)
        {
            _context = context;

            
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Examination>>> GetkrakiItems()
        {
            return await _context.Examinations.ToListAsync();
        }


// GET: api/Todo/5
[HttpGet("{id}")]
public async Task<ActionResult<Examination>> GetExaminationItems(int id)
{
    var todoItem = await _context.Examinations.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    return todoItem;
}
[HttpPost]
public async Task<IActionResult> PostTodoItem(Examination item)
{
    _context.Examinations.Add(item);
    await _context.SaveChangesAsync();
    return StatusCode(201);
}

[HttpPut("{id}")]
public async Task<IActionResult> PutTodoItem(int id, [FromBody] Examination item)
{
 
item.Id=id;
    _context.Entry(item).State = EntityState.Modified;
    await _context.SaveChangesAsync();

    return NoContent();
}

[HttpDelete("{id}")]
public async Task<IActionResult> DeleteTodoItem(int id)
{
    var todoItem = await _context.Examinations.FindAsync(id);

    if (todoItem == null)
    {
        return NotFound();
    }

    _context.Examinations.Remove(todoItem);
    await _context.SaveChangesAsync();

    return NoContent();
}

    }
}