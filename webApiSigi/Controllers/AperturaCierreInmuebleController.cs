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
    public class AperturaCierreInmuebleController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public AperturaCierreInmuebleController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/AperturaCierreInmueble
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TAperturaCierreInmueble>>> GetTAperturaCierreInmuebles()
        {
            return await _context.TAperturaCierreInmuebles.ToListAsync();
        }

        // GET: api/AperturaCierreInmueble/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TAperturaCierreInmueble>> GetTAperturaCierreInmueble(int id)
        {
            var tAperturaCierreInmueble = await _context.TAperturaCierreInmuebles.FindAsync(id);

            if (tAperturaCierreInmueble == null)
            {
                return NotFound();
            }

            return tAperturaCierreInmueble;
        }

        // PUT: api/AperturaCierreInmueble/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTAperturaCierreInmueble(int id, TAperturaCierreInmueble tAperturaCierreInmueble)
        {
            if (id != tAperturaCierreInmueble.CodAperturaCierreInmueble)
            {
                return BadRequest();
            }

            _context.Entry(tAperturaCierreInmueble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TAperturaCierreInmuebleExists(id))
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

        // POST: api/AperturaCierreInmueble
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TAperturaCierreInmueble>> PostTAperturaCierreInmueble(TAperturaCierreInmueble tAperturaCierreInmueble)
        {
            _context.TAperturaCierreInmuebles.Add(tAperturaCierreInmueble);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTAperturaCierreInmueble", new { id = tAperturaCierreInmueble.CodAperturaCierreInmueble }, tAperturaCierreInmueble);
        }

        // DELETE: api/AperturaCierreInmueble/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTAperturaCierreInmueble(int id)
        {
            var tAperturaCierreInmueble = await _context.TAperturaCierreInmuebles.FindAsync(id);
            if (tAperturaCierreInmueble == null)
            {
                return NotFound();
            }

            _context.TAperturaCierreInmuebles.Remove(tAperturaCierreInmueble);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TAperturaCierreInmuebleExists(int id)
        {
            return _context.TAperturaCierreInmuebles.Any(e => e.CodAperturaCierreInmueble == id);
        }
    }
}
