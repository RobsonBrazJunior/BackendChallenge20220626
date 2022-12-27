using OpenFood.Application.Interfaces;
using OpenFood.Domain.Models;
using OpenFood.Infra.Data.Repository.Interfaces;

namespace OpenFood.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Product GetById(int id) => _unitOfWork.Product.GetById(id);

        public IEnumerable<Product> GetAll() => _unitOfWork.Product.GetAll();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
