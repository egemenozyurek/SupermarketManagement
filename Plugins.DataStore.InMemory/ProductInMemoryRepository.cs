using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private readonly List<Product> products;
        public ProductInMemoryRepository()
        {
            //Init with default values
            products = new List<Product>()
            {
                new Product {ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100, Price=1.99},
                new Product {ProductId = 2, CategoryId = 1, Name = "Canada Dry", Quantity = 200, Price=1.99},
                new Product {ProductId = 3, CategoryId = 2, Name = "Whole Wheat Bread", Quantity = 300, Price=1.50},
                new Product {ProductId = 4, CategoryId = 2, Name = "White Bread", Quantity = 300, Price=1.50},
            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(p => p.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;

            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(p => p.ProductId);
                product.ProductId = maxId + 1;

            }
            else
            {
                product.ProductId = 1;
            }

            products.Add(product);
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }

        public Product GetProductById(int productId)
        {
            return products?.FirstOrDefault(p => p.ProductId == productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);

            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }
    }
}
