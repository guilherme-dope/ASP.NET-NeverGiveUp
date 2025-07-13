using MinhaListadeTarefas.Models;

namespace MinhaListadeTarefas.Repositories
{
    public class RepositoryPrioridade : RepositoryBase<Prioridade>
    {
        public RepositoryPrioridade(AppDbContext contexto, bool saveChanges = true)
            : base(contexto, saveChanges)
        {
        }
    }
}