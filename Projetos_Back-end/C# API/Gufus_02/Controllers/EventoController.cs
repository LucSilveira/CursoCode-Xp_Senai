using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufus.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        
        GufosContext context = new GufosContext();

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<List<Evento>>> Get(){

            List<Evento> listaEvento = await context.Evento.Include(cat => cat.Categoria).Include(loca => loca.Localizacao).Include(prs => prs.Presenca).ToListAsync();

            if(listaEvento == null){

                return NotFound();
            }

            return listaEvento;
        }
        

        [HttpGet("{id_event}")]
        public async Task<ActionResult<Evento>> Get(int id_event){

            Evento eventoRetornada = await context.Evento.Include(cat => cat.Categoria).Include(loca => loca.Localizacao).FirstOrDefaultAsync(evt => evt.EventoId == id_event);

            if(eventoRetornada == null){

                return NotFound();
            }

            return eventoRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<Evento>> Post(Evento Evento){

            try{

                await context.Evento.AddAsync(Evento);
                await context.SaveChangesAsync();

            }catch(System.Exception){

                throw;
            }

            return Evento;
        }


        [HttpPut("{id_event}")]
        public async Task<ActionResult<Evento>> Put(int id_event, Evento Evento){

            if(id_event != Evento.EventoId){

                return BadRequest();
            }

            context.Entry(Evento).State = EntityState.Modified;

            try{

                await context.SaveChangesAsync();
            
            }catch(DbUpdateConcurrencyException){

                var EventoValida = context.Evento.FindAsync(id_event);

                if(EventoValida == null){

                    return NotFound();

                }else{

                    throw;
                }
            }

            return Evento;
        }


        [HttpDelete("{id_event}")]
        public async Task<ActionResult<Evento>> Delete(int id_event){

            Evento eventoRetornada = await context.Evento.FindAsync(id_event);

            if(eventoRetornada == null){

                return NotFound();
            }

            context.Evento.Remove(eventoRetornada);
            await context.SaveChangesAsync();
            return eventoRetornada;
        }
    }
}