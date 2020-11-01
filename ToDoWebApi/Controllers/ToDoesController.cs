using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoWebApi.Models;

namespace ToDoWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/ToDoes")]
    public class ToDoesController : Controller
    {
        private readonly ToDoWebApiContext _context;

        public ToDoesController(ToDoWebApiContext context)
        {
            _context = context;
        }

        // GET: api/ToDoes
        [HttpGet]
        public IEnumerable<ToDo> GetToDo()
        {
            return _context.ToDo;
        }

        // GET: api/ToDoes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetToDo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var toDo = await _context.ToDo.SingleOrDefaultAsync(m => m.Id == id);

            if (toDo == null)
            {
                return NotFound();
            }

            return Ok(toDo);
        }

        // PUT: api/ToDoes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDo([FromRoute] int id, [FromBody] ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != toDo.Id)
            {
                return BadRequest();
            }

            _context.Entry(toDo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ToDoes
        [HttpPost]
        public async Task<IActionResult> PostToDo([FromBody] ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ToDo.Add(toDo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
        }

        // DELETE: api/ToDoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDo([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var toDo = await _context.ToDo.SingleOrDefaultAsync(m => m.Id == id);
            if (toDo == null)
            {
                return NotFound();
            }

            _context.ToDo.Remove(toDo);
            await _context.SaveChangesAsync();

            return Ok(toDo);
        }

        private bool ToDoExists(int id)
        {
            return _context.ToDo.Any(e => e.Id == id);
        }
    }
}