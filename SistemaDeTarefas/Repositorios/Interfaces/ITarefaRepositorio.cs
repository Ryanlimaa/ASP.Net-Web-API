using SistemaDeTarefas.Model;

namespace SistemaDeTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        // Definir os métodos que serão implementados no repositório de tarefas 
        Task<List<TarefaModel>> BuscarTarefa();

        Task<TarefaModel> BuscarPorId(int id);

        Task<TarefaModel> Adicionar(TarefaModel tarefa);

        Task<TarefaModel> Atualizar(TarefaModel tarefa, int id);

        Task<bool> Apagar(int id);
    }
}
