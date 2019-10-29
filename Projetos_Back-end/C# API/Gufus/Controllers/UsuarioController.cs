using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufus.Controllers
{
    
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        
        GufosContext context = new GufosContext();

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> Get(){

            List<Usuario> listaUsuario = await context.Usuario.Include(tpusr => tpusr.TipoUsuario).ToListAsync();

            if(listaUsuario == null){

                return NotFound();
            }

            return listaUsuario;
        }
        

        [HttpGet("{id_usr}")]
        public async Task<ActionResult<Usuario>> Get(int id_usr){

            Usuario UsuarioRetornada = await context.Usuario.Include(tpusr => tpusr.TipoUsuario).FirstOrDefaultAsync(usr => usr.UsuarioId == id_usr);

            if(UsuarioRetornada == null){

                return NotFound();
            }

            return UsuarioRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario usuario){

            try{

                await context.Usuario.AddAsync(usuario);
                await context.SaveChangesAsync();

            }catch(System.Exception){

                throw;
            }

            return usuario;
        }


        [HttpPut("{id_usr}")]
        public async Task<ActionResult<Usuario>> Put(int id_usr, Usuario usuario){

            if(id_usr != usuario.UsuarioId){

                return BadRequest();
            }

            context.Entry(usuario).State = EntityState.Modified;

            try{

                await context.SaveChangesAsync();
            
            }catch(DbUpdateConcurrencyException){

                var UsuarioValida = context.Usuario.FindAsync(id_usr);

                if(UsuarioValida == null){

                    return NotFound();

                }else{

                    throw;
                }
            }

            return usuario;
        }


        [HttpDelete("{id_usr}")]
        public async Task<ActionResult<Usuario>> Delete(int id_usr){

            Usuario UsuarioRetornada = await context.Usuario.FindAsync(id_usr);

            if(UsuarioRetornada == null){

                return NotFound();
            }

            context.Usuario.Remove(UsuarioRetornada);
            await context.SaveChangesAsync();
            return UsuarioRetornada;
        }
    }
}