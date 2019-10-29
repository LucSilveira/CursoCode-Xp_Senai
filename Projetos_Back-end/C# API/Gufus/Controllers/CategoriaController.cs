using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Gufus.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gufus.Repositorios;

namespace Gufus.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        
        GufosContext context = new GufosContext();

        CategoriaRepositorio repositorio = new CategoriaRepositorio();

        [HttpGet]
        public async Task<ActionResult<List<Categoria>>> Get(){

            try{

                return await repositorio.Get();
            }catch(System.Exception){
                throw;
            }
        }

        [HttpGet("{id_catg}")]
        public async Task<ActionResult<Categoria>> Get(int id_catg){

            Categoria categoriaRetornada = await context.Categoria.FindAsync(id_catg);

            if(categoriaRetornada == null){

                return NotFound();
            }

            return categoriaRetornada;
        }


        [HttpPost]
        public async Task<ActionResult<Categoria>> Post(Categoria categoria){
            try{

                return await repositorio.Post(categoria);
            }catch(System.Exception){
                throw;
            }
        }

        [HttpPut("{id_catg}")]
        public async Task<ActionResult> Put(int id_catg, Categoria categoria){

            Categoria categoriaRetornada = await context.Categoria.FindAsync(id_catg);

            if(categoriaRetornada == null){

                return NotFound();
            }

            // categoriaRetornada.Titulo = categoria.Titulo;
            // context.Categoria.Update(categoriaRetornada);
            await context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id_catg}")]
        public async Task<ActionResult<Categoria>> Delete(int id_catg){

            Categoria categoriaRetornada = await context.Categoria.FindAsync(id_catg);

            if(categoriaRetornada == null){

                return NotFound();
            }

            context.Categoria.Remove(categoriaRetornada);
            await context.SaveChangesAsync();

            return categoriaRetornada;
        }
    }
}