using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Model;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefaDBContext : DbContext
    {
        // Construtor para configurar o contexto do banco de dados, recebendo as opções de configuração 
        public SistemaTarefaDBContext(DbContextOptions<SistemaTarefaDBContext> options) : base(options)
        {
        }

        // Definindo as DbSet para as entidades do banco de dados, permitindo a manipulação dos dados através do Entity Framework Core  
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        // Sobrescrevendo o método OnModelCreating para configurar o modelo do banco de dados, se necessário    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
