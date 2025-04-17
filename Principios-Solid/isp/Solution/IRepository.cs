namespace isp.Solution
{
    // Interfaces segregadas por responsabilidade
    public interface IRepository<T>
    {
        void Adicionar(T entity);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
    }
}
