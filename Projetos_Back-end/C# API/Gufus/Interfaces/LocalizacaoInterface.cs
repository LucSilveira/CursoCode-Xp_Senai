using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Models;

namespace Gufus.Interfaces
{
    public interface LocalizacaoInterface
    {
        Task<List<Localizacao>> Get();

        Task<Localizacao> Get(int id);

        Task<Localizacao> Post(Localizacao localizacao);

        Task<Localizacao> Put(Localizacao localizacao);

        Task<Localizacao> Delete(Localizacao localizacao);
    }
}