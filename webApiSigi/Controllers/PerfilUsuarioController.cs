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
    public class PerfilUsuarioController : ControllerBase
    {
        private readonly ApiDbContextSigi _context;

        public PerfilUsuarioController(ApiDbContextSigi context)
        {
            _context = context;
        }

        // GET: api/PerfilUsuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TPerfilUsuario>>> GetTPerfilUsuarios()
        {
            return await _context.TPerfilUsuarios.ToListAsync();
        }

        // GET: api/PerfilUsuario/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TPerfilUsuario>> GetTPerfilUsuario(int id)
        {
            var tPerfilUsuario = await _context.TPerfilUsuarios.FindAsync(id);

            if (tPerfilUsuario == null)
            {
                return NotFound();
            }

            return tPerfilUsuario;
        }

        // PUT: api/PerfilUsuario/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTPerfilUsuario(int id, TPerfilUsuario tPerfilUsuario)
        {
            if (id != tPerfilUsuario.CodPerfil)
            {
                return BadRequest();
            }

            _context.Entry(tPerfilUsuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TPerfilUsuarioExists(id))
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

        // POST: api/PerfilUsuario
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TPerfilUsuario>> PostTPerfilUsuario(TPerfilUsuario tPerfilUsuario)
        {
            // Obtener el nuevo valor para CodPerfil
            int nuevoCodPerfil = 1;

            if (_context.TPerfilUsuarios.Any())
            {
                nuevoCodPerfil = _context.TPerfilUsuarios.Max(t => t.CodPerfil) + 1;
            }

            tPerfilUsuario.CodPerfil = nuevoCodPerfil;
            _context.TPerfilUsuarios.Add(tPerfilUsuario);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TPerfilUsuarioExists(tPerfilUsuario.CodPerfil))
                {
                    ModelState.AddModelError("CodPerfil", "El perfil ya existe.");
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                // Manejar otros tipos de excepciones y errores
                return StatusCode(500, $"Error interno del servidor: {ex.Message}");
            }
            return CreatedAtAction("GetTPerfilUsuario", new { id = tPerfilUsuario.CodPerfil }, tPerfilUsuario);
        }


        // DELETE: api/PerfilUsuario/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTPerfilUsuario(int id)
        {
            var tPerfilUsuario = await _context.TPerfilUsuarios.FindAsync(id);
            if (tPerfilUsuario == null)
            {
                return NotFound();
            }

            _context.TPerfilUsuarios.Remove(tPerfilUsuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TPerfilUsuarioExists(int id)
        {
            return _context.TPerfilUsuarios.Any(e => e.CodPerfil == id);
        }
    }
}
