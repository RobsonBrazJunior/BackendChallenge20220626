using OpenFood.Domain.Models;

namespace OpenFood.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        Product GetById(int id);
        IEnumerable<Product> GetAll();
    }
}
