using MinhaListadeTarefas.Models;

namespace MinhaListadeTarefas.Repositories
{
    public class RepositoryStatus : RepositoryBase<Status>
    {
        public RepositoryStatus(AppDbContext contexto, bool saveChanges = true) 
            : base(contexto, saveChanges)
        {
        }
    
    }
}
