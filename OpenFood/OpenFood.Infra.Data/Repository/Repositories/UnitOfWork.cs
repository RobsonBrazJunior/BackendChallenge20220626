using OpenFood.Infra.Data.Context;
using OpenFood.Infra.Data.Repository.Interfaces;

namespace OpenFood.Infra.Data.Repository.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        private readonly IProductRepository _product;

        public IProductRepository Product { get { return _product; } }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            _product = new ProductRepository(context);
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
