using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Entities.Dtos;

namespace Repositories
{
    
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {

        }
        
        public IQueryable<Product> GetAllProducts(bool trackChanges) =>
            FindAll(trackChanges);
    
        // Interface
        public Product? GetOneProduct(int ProductID, bool trackChanges)
        {
            
            Product product;

            if (trackChanges)
            {
                product = _context.Products.FirstOrDefault(p => p.ProductID == ProductID)!;
                if (product == null)
                {
                    return null;
                }
            }
            else
            {
                product = _context.Products.AsNoTracking().FirstOrDefault(p => p.ProductID == ProductID)!;
                if (product == null)
                {
                    return null;
                }
            }

            return product;
            

        }

        public void CreateOneProduct(Product product) => Create(product);

        public void DeleteOneProduct(Product product) => Remove(product);

        public void UpdateOneProduct(Product entity) => Update(entity);
        
    }
    
}
