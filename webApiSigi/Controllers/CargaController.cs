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
    public class CargaController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public CargaController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Carga
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TCarga>>> GetTCargas()
        {
            return await _context.TCargas.ToListAsync();
        }

        // GET: api/Carga/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TCarga>> GetTCarga(int? id)
        {
            var tCarga = await _context.TCargas.FindAsync(id);

            if (tCarga == null)
            {
                return NotFound();
            }

            return tCarga;
        }

        // PUT: api/Carga/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTCarga(int? id, TCarga tCarga)
        {
            if (id != tCarga.CodCarga)
            {
                return BadRequest();
            }

            _context.Entry(tCarga).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TCargaExists(id))
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

        // POST: api/Carga
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TCarga>> PostTCarga(TCarga tCarga)
        {
            _context.TCargas.Add(tCarga);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTCarga", new { id = tCarga.CodCarga }, tCarga);
        }

        // DELETE: api/Carga/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTCarga(int? id)
        {
            var tCarga = await _context.TCargas.FindAsync(id);
            if (tCarga == null)
            {
                return NotFound();
            }

            _context.TCargas.Remove(tCarga);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TCargaExists(int? id)
        {
            return _context.TCargas.Any(e => e.CodCarga == id);
        }
    }
}
