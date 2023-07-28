using EducationApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationApp.Data.Concrete.EFCore.Configs
{
	public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
	{
		public void Configure(EntityTypeBuilder<ProductCategory> builder)
		{
			builder.HasKey(pc => new { pc.ProductId, pc.CategoryId });
			builder.HasData(
				new ProductCategory { ProductId = 1, CategoryId = 1 },
				new ProductCategory { ProductId = 2, CategoryId = 1 },
				new ProductCategory { ProductId = 3, CategoryId = 1 },
				new ProductCategory { ProductId = 4, CategoryId = 1 },
				new ProductCategory { ProductId = 5, CategoryId = 1 },
				new ProductCategory { ProductId = 6, CategoryId = 2 },
				new ProductCategory { ProductId = 8, CategoryId = 2 },
				new ProductCategory { ProductId = 9, CategoryId = 2 },
				new ProductCategory { ProductId = 10, CategoryId = 3 },
				new ProductCategory { ProductId = 11, CategoryId = 3 },
				new ProductCategory { ProductId = 12, CategoryId = 3 },
				new ProductCategory { ProductId = 13, CategoryId = 3 },
                new ProductCategory { ProductId = 14, CategoryId = 4 },
                new ProductCategory { ProductId = 15, CategoryId = 4 },
                new ProductCategory { ProductId = 16, CategoryId = 4 },
                new ProductCategory { ProductId = 17, CategoryId = 4 },
                new ProductCategory { ProductId = 18, CategoryId = 5 },
                new ProductCategory { ProductId = 19, CategoryId = 5 },
                new ProductCategory { ProductId = 20, CategoryId = 5 },
                new ProductCategory { ProductId = 21, CategoryId = 5 },
                new ProductCategory { ProductId = 22, CategoryId = 5 },
                new ProductCategory { ProductId = 23, CategoryId = 6 },
				new ProductCategory { ProductId = 24, CategoryId = 6 },
				new ProductCategory { ProductId = 25, CategoryId = 6 },
				new ProductCategory { ProductId = 26, CategoryId = 6 },
				new ProductCategory { ProductId = 27, CategoryId = 7 },
                new ProductCategory { ProductId = 28, CategoryId = 7 },
                new ProductCategory { ProductId = 29, CategoryId = 7 },
                new ProductCategory { ProductId = 30, CategoryId = 7 });
        }
	}
}
