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
    public class TipoUsuarioController : ControllerBase
    {

        GufosContext context = new GufosContext();

        [HttpGet]
        public async Task<ActionResult<List<TipoUsuario>>> Get(){

            List<TipoUsuario> listaTipoUsuario = await context.TipoUsuario.ToListAsync();

            if(listaTipoUsuario == null){

                return NotFound();
            }

            return listaTipoUsuario;
        }
        

        [HttpGet("{id_tpusr}")]
        public async Task<ActionResult<TipoUsuario>> Get(int id_tpusr){

            TipoUsuario tipoUsuarioRetornada = await context.TipoUsuario.FindAsync(id_tpusr);

            if(tipoUsuarioRetornada == null){

                return NotFound();
            }

            return tipoUsuarioRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<TipoUsuario>> Post(TipoUsuario TipoUsuario){

            try{

                await context.TipoUsuario.AddAsync(TipoUsuario);
                await context.SaveChangesAsync();

            }catch(System.Exception){

                throw;
            }

            return TipoUsuario;
        }


        [HttpPut("{id_tpusr}")]
        public async Task<ActionResult<TipoUsuario>> Put(int id_tpusr, TipoUsuario tipoUsuario){

            if(id_tpusr != tipoUsuario.TipoUsuarioId){

                return BadRequest();
            }

            context.Entry(tipoUsuario).State = EntityState.Modified;

            try{

                await context.SaveChangesAsync();
            
            }catch(DbUpdateConcurrencyException){

                var TipoUsuarioValida = context.TipoUsuario.FindAsync(id_tpusr);

                if(TipoUsuarioValida == null){

                    return NotFound();

                }else{

                    throw;
                }
            }

            return tipoUsuario;
        }


        [HttpDelete("{id_tpusr}")]
        public async Task<ActionResult<TipoUsuario>> Delete(int id_tpusr){

            TipoUsuario tipoUsuarioRetornada = await context.TipoUsuario.FindAsync(id_tpusr);

            if(tipoUsuarioRetornada == null){

                return NotFound();
            }

            context.TipoUsuario.Remove(tipoUsuarioRetornada);
            await context.SaveChangesAsync();
            return tipoUsuarioRetornada;
        }
    }
}