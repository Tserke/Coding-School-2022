﻿using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class ProductRepo : IEntityRepo<Product>
    {
        public async Task Create(Product entity)
        {
            using var context = new CoffeeShopContext();
            context.Products.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            using var context = new CoffeeShopContext();
            var foundProduct = context.Products.SingleOrDefault(product => product.Id == id);
            if (foundProduct is null)
                return;

            context.Products.Remove(foundProduct);
            await context.SaveChangesAsync();
        }

        public List<Product> GetAll()
        {
            using var context = new CoffeeShopContext();
            return context.Products.ToList();
        }

        public Product? GetById(int id)
        {
            using var context = new CoffeeShopContext();
            return context.Products.Where(product => product.Id == id).SingleOrDefault();
        }

        //TODO: add functionality
        public async Task Update(int id, Product entity)
        {
            using var context = new CoffeeShopContext();
            var foundProduct = context.Products.SingleOrDefault(product => product.Id == id);
            if (foundProduct is null)
                return;

            foundProduct.ProductCategory = entity.ProductCategory;
            foundProduct.Description = entity.Description;
            foundProduct.Code = entity.Code;
            foundProduct.Price = entity.Price;
            foundProduct.Cost = entity.Cost;
            await context.SaveChangesAsync();
        }
    }
}
