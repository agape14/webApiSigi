using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApiSigi.Models;

namespace webApiSigi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActoAnulaController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public ActoAnulaController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/ActoAnula
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TActoAnulacion>>> GetTActoAnulacions()
        {
            return await _context.TActoAnulacions.ToListAsync();
        }

        // GET: api/ActoAnula/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TActoAnulacion>> GetTActoAnulacion(int id)
        {
            var tActoAnulacion = await _context.TActoAnulacions.FindAsync(id);

            if (tActoAnulacion == null)
            {
                return NotFound();
            }

            return tActoAnulacion;
        }

        // PUT: api/ActoAnula/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTActoAnulacion(int id, TActoAnulacion tActoAnulacion)
        {
            if (id != tActoAnulacion.CodActoAnulacion)
            {
                return BadRequest();
            }

            _context.Entry(tActoAnulacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TActoAnulacionExists(id))
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

        // POST: api/ActoAnula
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TActoAnulacion>> PostTActoAnulacion(TActoAnulacion tActoAnulacion)
        {
            _context.TActoAnulacions.Add(tActoAnulacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTActoAnulacion", new { id = tActoAnulacion.CodActoAnulacion }, tActoAnulacion);
        }

        // DELETE: api/ActoAnula/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTActoAnulacion(int id)
        {
            var tActoAnulacion = await _context.TActoAnulacions.FindAsync(id);
            if (tActoAnulacion == null)
            {
                return NotFound();
            }

            _context.TActoAnulacions.Remove(tActoAnulacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TActoAnulacionExists(int id)
        {
            return _context.TActoAnulacions.Any(e => e.CodActoAnulacion == id);
        }
    }
}
