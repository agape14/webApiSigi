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
    public class ActoBeneficiarioController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public ActoBeneficiarioController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/ActoBeneficiario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TActoBeneficiario>>> GetTActoBeneficiarios()
        {
            return await _context.TActoBeneficiarios.ToListAsync();
        }

        // GET: api/ActoBeneficiario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TActoBeneficiario>> GetTActoBeneficiario(int? id)
        {
            var tActoBeneficiario = await _context.TActoBeneficiarios.FindAsync(id);

            if (tActoBeneficiario == null)
            {
                return NotFound();
            }

            return tActoBeneficiario;
        }

        // PUT: api/ActoBeneficiario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTActoBeneficiario(int? id, TActoBeneficiario tActoBeneficiario)
        {
            if (id != tActoBeneficiario.CodBenef)
            {
                return BadRequest();
            }

            _context.Entry(tActoBeneficiario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TActoBeneficiarioExists(id))
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

        // POST: api/ActoBeneficiario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TActoBeneficiario>> PostTActoBeneficiario(TActoBeneficiario tActoBeneficiario)
        {
            _context.TActoBeneficiarios.Add(tActoBeneficiario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTActoBeneficiario", new { id = tActoBeneficiario.CodBenef }, tActoBeneficiario);
        }

        // DELETE: api/ActoBeneficiario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTActoBeneficiario(int? id)
        {
            var tActoBeneficiario = await _context.TActoBeneficiarios.FindAsync(id);
            if (tActoBeneficiario == null)
            {
                return NotFound();
            }

            _context.TActoBeneficiarios.Remove(tActoBeneficiario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TActoBeneficiarioExists(int? id)
        {
            return _context.TActoBeneficiarios.Any(e => e.CodBenef == id);
        }
    }
}
