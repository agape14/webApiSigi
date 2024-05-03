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
    public class ActoController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public ActoController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/Acto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TActo>>> GetTActos()
        {
            return await _context.TActos.ToListAsync();
        }

        // GET: api/Acto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TActo>> GetTActo(int id)
        {
            var tActo = await _context.TActos.FindAsync(id);

            if (tActo == null)
            {
                return NotFound();
            }

            return tActo;
        }

        // PUT: api/Acto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTActo(int id, TActo tActo)
        {
            if (id != tActo.CodActo)
            {
                return BadRequest();
            }

            _context.Entry(tActo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TActoExists(id))
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

        // POST: api/Acto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TActo>> PostTActo(TActo tActo)
        {
            _context.TActos.Add(tActo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TActoExists(tActo.CodActo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTActo", new { id = tActo.CodActo }, tActo);
        }

        // DELETE: api/Acto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTActo(int id)
        {
            var tActo = await _context.TActos.FindAsync(id);
            if (tActo == null)
            {
                return NotFound();
            }

            _context.TActos.Remove(tActo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TActoExists(int id)
        {
            return _context.TActos.Any(e => e.CodActo == id);
        }
    }
}
