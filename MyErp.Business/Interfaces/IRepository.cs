namespace MyErp.Business.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T entity);
        IEnumerable<T> GetAll();
    }
}
