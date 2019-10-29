using System.Collections.Generic;
using System.Threading.Tasks;
using Gufus.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gufus.Interfaces
{
    public interface CategoriaInterface
    {
        Task<List<Categoria>> Get();

        Task<Categoria> Get(int id);

        Task<Categoria> Post(Categoria categoria);

        Task<Categoria> Put(int id, Categoria categoria);

        Task<Categoria> Delete(int id);
    }
}