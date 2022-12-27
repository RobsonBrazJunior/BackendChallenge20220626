namespace OpenFood.Infra.Data.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get; }
        int Save();
    }
}
