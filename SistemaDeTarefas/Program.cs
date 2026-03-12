using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;

namespace SistemaDeTarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Configurando a string de conexão para o banco de dados MySQL, obtendo-a do arquivo de configuração appsettings.json  
            var connectionString = builder.Configuration.GetConnectionString("DataBase");

            // Configurando o contexto do banco de dados para usar o MySQL, utilizando a string de conexão definida anteriormente e detectando automaticamente a versão do servidor MySQL   
            builder.Services.AddDbContext<Data.SistemaTarefaDBContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            // Registrando o repositório de usuário e tarefas para injeção de dependência, permitindo que ele seja utilizado em outras partes da aplicação, como nos controladores, para acessar os dados no banco de dados  
            builder.Services.AddScoped<Repositorios.Interfaces.IUsuarioRepositorio, Repositorios.UsuarioRepositorio>();
            builder.Services.AddScoped<Repositorios.Interfaces.ITarefaRepositorio, Repositorios.TarefaRepositorio>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
