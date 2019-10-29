using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Interfaces;
using Gufus.Models;
using Microsoft.EntityFrameworkCore;

namespace Gufus.Repositorios
{
    public class LocalizacaoRepositorio : LocalizacaoInterface
    {

        GufosContext context = new GufosContext();

        
        public async Task<List<Localizacao>> Get()
        {
            return await context.Localizacao.ToListAsync();
        }

        public async Task<Localizacao> Get(int id)
        {
            return await context.Localizacao.FindAsync(id);
        }

        public Task<Localizacao> Post(Localizacao localizacao)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Localizacao> Put(Localizacao localizacao)
        {
            context.Entry(localizacao).State = EntityState.Modified;
            await context.SaveChangesAsync();

            return localizacao;
        }

        public async Task<Localizacao> Delete(Localizacao localizacaoRetornada)
        {
            context.Localizacao.Remove(localizacaoRetornada);
            await context.SaveChangesAsync();

            return localizacaoRetornada;
        }
    }
}