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
    public class BancoController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public BancoController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Banco
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBanco>>> GetTBancos()
        {
            return await _context.TBancos.ToListAsync();
        }

        // GET: api/Banco/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TBanco>> GetTBanco(int id)
        {
            var tBanco = await _context.TBancos.FindAsync(id);

            if (tBanco == null)
            {
                return NotFound();
            }

            return tBanco;
        }

        // PUT: api/Banco/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTBanco(int id, TBanco tBanco)
        {
            if (id != tBanco.CodBanco)
            {
                return BadRequest();
            }

            _context.Entry(tBanco).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBancoExists(id))
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

        // POST: api/Banco
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TBanco>> PostTBanco(TBanco tBanco)
        {
            _context.TBancos.Add(tBanco);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TBancoExists(tBanco.CodBanco))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTBanco", new { id = tBanco.CodBanco }, tBanco);
        }

        // DELETE: api/Banco/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTBanco(int id)
        {
            var tBanco = await _context.TBancos.FindAsync(id);
            if (tBanco == null)
            {
                return NotFound();
            }

            _context.TBancos.Remove(tBanco);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TBancoExists(int id)
        {
            return _context.TBancos.Any(e => e.CodBanco == id);
        }
    }
}
