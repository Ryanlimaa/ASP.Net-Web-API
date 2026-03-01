using System.ComponentModel;

namespace SistemaDeTarefas.Model.Enum
{
    public enum Status
    {
        Pendente = 1,
        [Description("Em Processo")]
        EmProcesso = 2,
        Concluido = 3
    }
}
