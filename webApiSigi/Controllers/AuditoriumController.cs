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
    public class AuditoriumController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public AuditoriumController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Auditorium
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAuditorium>>> GetTAuditoria()
        {
            return await _context.TAuditoria.ToListAsync();
        }

        // GET: api/Auditorium/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAuditorium>> GetTAuditorium(int id)
        {
            var tAuditorium = await _context.TAuditoria.FindAsync(id);

            if (tAuditorium == null)
            {
                return NotFound();
            }

            return tAuditorium;
        }

        // PUT: api/Auditorium/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTAuditorium(int id, TAuditorium tAuditorium)
        {
            if (id != tAuditorium.CodA)
            {
                return BadRequest();
            }

            _context.Entry(tAuditorium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAuditoriumExists(id))
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

        // POST: api/Auditorium
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TAuditorium>> PostTAuditorium(TAuditorium tAuditorium)
        {
            _context.TAuditoria.Add(tAuditorium);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TAuditoriumExists(tAuditorium.CodA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTAuditorium", new { id = tAuditorium.CodA }, tAuditorium);
        }

        // DELETE: api/Auditorium/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTAuditorium(int id)
        {
            var tAuditorium = await _context.TAuditoria.FindAsync(id);
            if (tAuditorium == null)
            {
                return NotFound();
            }

            _context.TAuditoria.Remove(tAuditorium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TAuditoriumExists(int id)
        {
            return _context.TAuditoria.Any(e => e.CodA == id);
        }
    }
}
