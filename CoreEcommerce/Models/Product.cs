using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEcommerce.Models
{
    public class Product
    {
        [Key]
        public int productId { get; set; }

        public string name { get; set; }

        public string sku { get; set; }

        public decimal price { get; set; }

        public int maxQuantity { get; set; }

        // Add category
        
        public decimal restockingFee { get; set; }

        // Add vertical

        public decimal cogs { get; set; }

        public string description { get; set; }

        public bool subscription { get; set; }

        public int recurringProductId { get; set; }

        public bool shipping { get; set; }

        public decimal weight { get; set; }

        public decimal declaredValue { get; set; }

        public bool digital { get; set; }

        public string digitalUrl { get; set; }

        public bool active { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }

        public Product()
        {
            created = DateTime.UtcNow;
            updated = DateTime.UtcNow;
        }
    }

    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int id);
        Product CreateProduct(Product product);
        void DeleteProduct(int productID);
        void UpdateProduct(Product product);
        void Save();
    }

    public class ProductRepository : IProductRepository, IDisposable
    {
        private ApplicationContext context; 

        public ProductRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public Product GetProductByID(int id)
        {
            return context.Products.Find(id);
        }

        public Product CreateProduct (Product product)
        {
            context.Products.Add(product);
            Save();
            return product;
        }

        public void DeleteProduct(int productID)
        {
            Product product = context.Products.Find(productID);
            context.Products.Remove(product);
            Save();
        }

        public void UpdateProduct(Product product)
        {
            context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
