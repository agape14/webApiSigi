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
    public class PersonaController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public PersonaController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Persona
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TPersona>>> GetTPersonas()
        {
            return await _context.TPersonas.ToListAsync();
        }

        // GET: api/Persona/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TPersona>> GetTPersona(string id)
        {
            var tPersona = await _context.TPersonas.FindAsync(id);

            if (tPersona == null)
            {
                return NotFound();
            }

            return tPersona;
        }

        // PUT: api/Persona/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTPersona(string id, TPersona tPersona)
        {
            if (id != tPersona.CodPersona)
            {
                return BadRequest();
            }

            _context.Entry(tPersona).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TPersonaExists(id))
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

        // POST: api/Persona
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TPersona>> PostTPersona(TPersona tPersona)
        {
            _context.TPersonas.Add(tPersona);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TPersonaExists(tPersona.CodPersona))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTPersona", new { id = tPersona.CodPersona }, tPersona);
        }

        // DELETE: api/Persona/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTPersona(string id)
        {
            var tPersona = await _context.TPersonas.FindAsync(id);
            if (tPersona == null)
            {
                return NotFound();
            }

            _context.TPersonas.Remove(tPersona);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TPersonaExists(string id)
        {
            return _context.TPersonas.Any(e => e.CodPersona == id);
        }
    }
}
