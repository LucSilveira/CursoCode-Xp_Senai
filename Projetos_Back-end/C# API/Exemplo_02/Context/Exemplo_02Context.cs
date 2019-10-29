using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Exemplo_02.Models;

namespace Exemplo_02.Context
{
    public class Exemplo_02Context : DbContext
    {

        public Exemplo_02Context(){}

        public Exemplo_02Context(DbContextOptions<Exemplo_02Context> options):base(options){}

        // Atribuindo o model a tebela expecificada no banco
        // No caso, de usuairioModel a tabelaUsuario no banco
        public virtual DbSet<UsuarioModel> tbl_usuario{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            if(!optionsBuilder.IsConfigured){

                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; DataBase=aula_api; Integrated Security=true");
            }
        }
    }
}