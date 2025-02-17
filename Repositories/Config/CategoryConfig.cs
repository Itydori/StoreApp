using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryID);
            builder.Property(c => c.CategoryName);
            builder.HasData(
        new Category
        {
            CategoryID = 1,
            CategoryName = "InternalParts"
        },
        new Category
        {
            CategoryID = 2,
            CategoryName = "ExternalParts"
        },
        new Category
        {
            CategoryID = 3,
            CategoryName = "Connectivity"
        }
            );
        }
    }
}
