using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System.Collections.Generic;
using System.Linq;


namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;

        public CategoryManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IEnumerable<Category> GetAllCategories(bool trackChanges)
        {
            return _manager.Category.FindAll(trackChanges);
        }

        public Category? GetOneCategory(int categoryId, bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}