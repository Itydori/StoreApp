using Entities.Models;
using System.Collections.Generic;

namespace Services.Contracts
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories(bool trackChanges);
        Category? GetOneCategory(int categoryId, bool trackChanges);
    }
}