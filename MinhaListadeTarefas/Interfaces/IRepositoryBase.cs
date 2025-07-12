namespace MinhaListadeTarefas.Interfaces
{
    public interface IRepositoryBase
    {
       

        public interface IRepositoryBase<T> where T : class
        {
            // Async methods for CRUD operations

            Task<T> SelecionarChaveAsync(params object[] variavel);
            Task<T> IncluirAsync(T entity);
            Task<T> AlterarAsync(T entity);
            Task<List<T>> ListarTodosAsync();
            Task ExcluirAsync(T entity);

            Task ExcluirAsync(int id);

            // Synchronous methods for CRUD operations

            T SelecionarChave(params object[] variavel);
            T Incluir(T entity);
            T Alterar(T entity);
            List<T> ListarTodos();
            void Excluir(T entity);
            void Excluir(int id);




        }
    }
}
