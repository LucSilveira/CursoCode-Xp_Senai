using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Tarefa.Models;

namespace Tarefa.Context
{
    public class TarefaContext : DbContext
    {
        
        public TarefaContext(){}

        public TarefaContext(DbContextOptions<TarefaContext> options):base(options){}

        public virtual DbSet<TarefaModel> tbl_tarefa{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; DataBase=tarefa; Integrated Security=true");
            }

        }

    }
}