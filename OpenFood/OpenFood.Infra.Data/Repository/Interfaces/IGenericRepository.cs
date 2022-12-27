namespace OpenFood.Infra.Data.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
