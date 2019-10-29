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
    public class PresencaController : ControllerBase
    {
        GufosContext context = new GufosContext();

        [HttpGet]
        public async Task<ActionResult<List<Presenca>>> Get(){

            List<Presenca> listaPresenca = await context.Presenca.Include(usr => usr.Usuario).Include(evnt => evnt.Evento).ToListAsync();

            if(listaPresenca == null){

                return NotFound();
            }

            return listaPresenca;
        }
        

        [HttpGet("{id_prsc}")]
        public async Task<ActionResult<Presenca>> Get(int id_prsc){

            Presenca presencaRetornada = await context.Presenca.FindAsync(id_prsc);

            if(presencaRetornada == null){

                return NotFound();
            }

            return presencaRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<Presenca>> Post(Presenca Presenca){

            try{

                await context.Presenca.AddAsync(Presenca);
                await context.SaveChangesAsync();

            }catch(System.Exception){

                throw;
            }

            return Presenca;
        }


        [HttpPut("{id_prsc}")]
        public async Task<ActionResult<Presenca>> Put(int id_prsc, Presenca Presenca){

            if(id_prsc != Presenca.PresencaId){

                return BadRequest();
            }

            context.Entry(Presenca).State = EntityState.Modified;

            try{

                await context.SaveChangesAsync();
            
            }catch(DbUpdateConcurrencyException){

                var PresencaValida = context.Presenca.FindAsync(id_prsc);

                if(PresencaValida == null){

                    return NotFound();

                }else{

                    throw;
                }
            }

            return Presenca;
        }


        [HttpDelete("{id_prsc}")]
        public async Task<ActionResult<Presenca>> Delete(int id_prsc){

            Presenca PresencaRetornada = await context.Presenca.FindAsync(id_prsc);

            if(PresencaRetornada == null){

                return NotFound();
            }

            context.Presenca.Remove(PresencaRetornada);
            await context.SaveChangesAsync();
            return PresencaRetornada;
        }
    }
}