using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Models;
using Gufus.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gufus.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class LocalizacaoController : ControllerBase
    {

        GufosContext context = new GufosContext();

        LocalizacaoRepositorio repositorio = new LocalizacaoRepositorio();

        [HttpGet]
        public async Task<ActionResult<List<Localizacao>>> Get(){

            List<Localizacao> listaLocalizacao = await repositorio.Get();

            if(listaLocalizacao == null){

                return NotFound();
            }

            return listaLocalizacao;
        }
        

        [HttpGet("{id_loca}")]
        public async Task<ActionResult<Localizacao>> Get(int id_loca){

            Localizacao localizacaoRetornada = await context.Localizacao.FindAsync(id_loca);

            if(localizacaoRetornada == null){

                return NotFound();
            }

            return localizacaoRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<Localizacao>> Post(Localizacao localizacao){

            try{

                await context.Localizacao.AddAsync(localizacao);
                await context.SaveChangesAsync();

            }catch(System.Exception){

                throw;
            }

            return localizacao;
        }


        [HttpPut("{id_loca}")]
        public async Task<ActionResult<Localizacao>> Put(int id_loca, Localizacao localizacao){

            if(id_loca != localizacao.LocalizacaoId){

                return BadRequest();
            }

            try{

                await repositorio.Put(localizacao);   
            
            }catch(DbUpdateConcurrencyException){

                var localizacaoValida = repositorio.Get(id_loca);

                if(localizacaoValida == null){

                    return NotFound();

                }else{

                    throw;
                }
            }

            return localizacao;
        }


        [HttpDelete("{id_loca}")]
        public async Task<ActionResult<Localizacao>> Delete(int id_loca){

            Localizacao localizacaoRetornada = await repositorio.Get(id_loca);

            if(localizacaoRetornada == null){

                return NotFound();
            }

            await repositorio.Delete(localizacaoRetornada);
            
            return localizacaoRetornada;
        }
    }
}