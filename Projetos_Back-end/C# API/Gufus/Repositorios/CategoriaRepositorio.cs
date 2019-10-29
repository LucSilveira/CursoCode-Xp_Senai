using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gufus.Interfaces;
using Gufus.Models;
using Microsoft.EntityFrameworkCore;

namespace Gufus.Repositorios
{
    public class CategoriaRepositorio : CategoriaInterface
    {

        GufosContext context = new GufosContext();

        public Task<Categoria> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

          public async Task<List<Categoria>> Get()
        {
            return await context.Categoria.ToListAsync();
        }

        public async Task<Categoria> Get(int id)
        {
            return await context.Categoria.FindAsync(id);
        }

        public Task<Categoria> Post(Categoria categoria)
        {
            throw new System.NotImplementedException();
        }

        public Task<Categoria> Put(int id, Categoria categoria)
        {
            throw new System.NotImplementedException();
        }
    }
}