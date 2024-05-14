using Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDal : IProductDal
    {
        public int products { get; set; }  
        List<Product> _products;
        List<Product> _list1;
        public ProductDal()
        {

            List<Product> products = new List<Product>();
            products.Add(new Product { CategoryId = 1, ProductId = 1, ProductName = "A", UnitPrice = 10, UnitsInStock = 3 });
            products.Add(new Product { CategoryId = 2, ProductId = 2, ProductName = "B", UnitPrice = 1000, UnitsInStock = 1 });
            products.Add(new Product { CategoryId = 2, ProductId = 3, ProductName = "C", UnitPrice = 100, UnitsInStock = 2 });
            _products = products;

        }
        public List<Product> GetProducts(Func<Product, bool> filter = null)
        {
            return _products.Where(filter).ToList();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }


        public Product Get(Func<Product, bool> filter)
        {
            return _products.FirstOrDefault(filter);
        }

        public Product GetProductByName(string name)
        {
            var result = new Product();
            foreach (var product in _products)
            {
                if (product.ProductName == name)
                {
                    return product;
                }
            }

            return _products.FirstOrDefault(p => p.ProductName == name);
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);

        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}


