using Entities.Models;
using Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;
using Entities.Dtos;

namespace Services
{
    public class ProductService : Contracts.IProductService  // Sınıf adı ProductService olarak değiştirildi
    {
        private readonly IRepositoryManager _repositoryManager;  // Değişken ismi standartlaştırıldı

        public ProductService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public void CreateProduct(ProductDtoForInsertion productDto)
        {
            var entity = new Product()
            {
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                CategoryId = productDto.CategoryId
            };
            _repositoryManager.Product.CreateOneProduct(entity);
        }


        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _repositoryManager.Product.GetAllProducts(trackChanges).ToList();
        }

        public Product? GetOneProduct(int productId, bool trackChanges)
        {
            return _repositoryManager.Product.GetOneProduct(productId, trackChanges);
        }

        public void DeleteOneProduct(int id)
        {
            var entity = _repositoryManager.Product.GetOneProduct(id, false);
            if (entity != null)
            {
                _repositoryManager.Product.DeleteOneProduct(entity);
                _repositoryManager.Save();
            }
        }

        public void UpdateOneProduct(ProductDtoForUpdate productDto)
        {
            throw new NotImplementedException();
        }

        public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }        
}
