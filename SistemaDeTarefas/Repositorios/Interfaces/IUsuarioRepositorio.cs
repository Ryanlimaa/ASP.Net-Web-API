using SistemaDeTarefas.Model;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        // Definir os métodos que serão implementados no repositório de usuário 
        Task<List<UsuarioModel>> BuscarUsuarios();

        Task<UsuarioModel> BuscarPorId(int id);

        Task<UsuarioModel> Adicionar(UsuarioModel usuario);

        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);

        Task<bool> Apagar(int id);
    }
}
