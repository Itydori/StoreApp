using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(RepositoryContext context) : base(context)
        {
            
        }
        public IQueryable<Category> GetAllCategories(bool trackChanges)
        {
            // Implementation for GetAllCategories
            return FindAll(trackChanges).OrderBy(c => c.CategoryName);
        }

        public Category GetOneCategory(int id, bool trackChanges)
        {
            // Implementation for GetOneCategory
            return FindByCondition(c => c.CategoryID.Equals(id), trackChanges)?.SingleOrDefault();
        }
    }
}