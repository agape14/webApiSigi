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
    public class ComprobanteController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public ComprobanteController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Comprobante
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TComprobante>>> GetTComprobantes()
        {
            return await _context.TComprobantes.ToListAsync();
        }

        // GET: api/Comprobante/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TComprobante>> GetTComprobante(int id)
        {
            var tComprobante = await _context.TComprobantes.FindAsync(id);

            if (tComprobante == null)
            {
                return NotFound();
            }

            return tComprobante;
        }

        // PUT: api/Comprobante/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTComprobante(int id, TComprobante tComprobante)
        {
            if (id != tComprobante.CodComprob)
            {
                return BadRequest();
            }

            _context.Entry(tComprobante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TComprobanteExists(id))
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

        // POST: api/Comprobante
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TComprobante>> PostTComprobante(TComprobante tComprobante)
        {
            _context.TComprobantes.Add(tComprobante);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TComprobanteExists(tComprobante.CodComprob))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTComprobante", new { id = tComprobante.CodComprob }, tComprobante);
        }

        // DELETE: api/Comprobante/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTComprobante(int id)
        {
            var tComprobante = await _context.TComprobantes.FindAsync(id);
            if (tComprobante == null)
            {
                return NotFound();
            }

            _context.TComprobantes.Remove(tComprobante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TComprobanteExists(int id)
        {
            return _context.TComprobantes.Any(e => e.CodComprob == id);
        }
    }
}
