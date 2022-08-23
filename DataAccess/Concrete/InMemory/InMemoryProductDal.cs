using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product;
        public InMemoryProductDal()
        {
            _product = new List<Product> {
            new Product {CategoryId =1,ProductId=1, ProductName="BARDAK", UnitsInStock=15, UnitPrice=15},
            new Product {CategoryId =1,ProductId=2, ProductName="KAMERA", UnitsInStock=3, UnitPrice=500},
            new Product {CategoryId =2,ProductId=3, ProductName="TELEFON", UnitsInStock=2, UnitPrice=1500 },
            new Product {CategoryId =2,ProductId=4, ProductName="KLAVYE", UnitsInStock=65, UnitPrice=150},
            new Product {CategoryId =2,ProductId=5, ProductName="FARE", UnitsInStock=1, UnitPrice=85}
            };
        }
        public void Add(Product product)
        {
            _product.Add(product);
        }

        public void Delete(Product product)
        {
            Product producttoDelete = _product.SingleOrDefault(p=> p.ProductId== product.ProductId);
            _product.Remove(producttoDelete);
        }

        public List<Product> GetAll()
        {
            return _product;
        }

      

        public void Update(Product product)
        {
            Product producttoUpdate = _product.SingleOrDefault(p => p.ProductId == product.ProductId);
            producttoUpdate.ProductName = product.ProductName;
            producttoUpdate.CategoryId = product.CategoryId;
            producttoUpdate.UnitPrice = product.UnitPrice;
            producttoUpdate.UnitsInStock = product.UnitsInStock;
        }
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _product.Where (p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
