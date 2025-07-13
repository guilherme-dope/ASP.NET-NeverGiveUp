using MinhaListadeTarefas.Models;

namespace MinhaListadeTarefas.Repositories
{
    public class RepositoryTarefa: RepositoryBase<Tarefa>
    {
        public RepositoryTarefa(AppDbContext contexto, bool saveChanges = true) 
            : base(contexto, saveChanges)
        {

        }

    }
}
