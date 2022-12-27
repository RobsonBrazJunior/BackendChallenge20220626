using OpenFood.Domain.Models;
using OpenFood.Infra.Data.Context;
using OpenFood.Infra.Data.Repository.Interfaces;

namespace OpenFood.Infra.Data.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
