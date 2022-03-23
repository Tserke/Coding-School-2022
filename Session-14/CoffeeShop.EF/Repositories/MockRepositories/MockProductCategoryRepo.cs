using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class MockProductCategoryRepo : IEntityRepo<ProductCategory>
    {
        private List<ProductCategory> _products= new List<ProductCategory> { new ProductCategory() { Id=1}, new ProductCategory() { Id=2} };
        public async Task Create(ProductCategory entity)
        {
            using var context = new CoffeeShopContext();
            context.ProductCategories.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var context = new CoffeeShopContext();
            var foundProductCategory = context.ProductCategories.SingleOrDefault(category => category.Id == id);
            if (foundProductCategory is null)
                return;

            context.ProductCategories.Remove(foundProductCategory);
            await context.SaveChangesAsync();
        }

        public List<ProductCategory> GetAll()
        {
            using var context = new CoffeeShopContext();
            return context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(int id)
        {
            using var context = new CoffeeShopContext();
            return context.ProductCategories.Where(category => category.Id == id).SingleOrDefault();
        }
        // TODO: Check this if works
        public async Task Update(int id, ProductCategory entity)
        {
            using var context = new CoffeeShopContext();
            var foundCategory = context.ProductCategories.SingleOrDefault(category => category.Id == id);
            if (foundCategory is null)
                return;

            foundCategory.Code = entity.Code;
            foundCategory.Description = entity.Description;
            foundCategory.ProductType = entity.ProductType;
            await context.SaveChangesAsync();

        }
    }
}
