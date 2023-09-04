﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
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
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            //LINQ Olmadan 

            //Product productDelete= null;
            //foreach (var item in _products)
            //{
            //    if (item.ProductId == product.ProductId)
            //    {
            //        productDelete = item;
            //    }
            //}
            //_products.Remove(productDelete);

            // LINQ -- Language Integrated Query
            Product product1 = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            //Product product1 = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            //Ayni Anlama geliyor

            _products.Remove(product1);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product product1 = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            product1.ProductName = product.ProductName;
            product1.UnitPrice = product.UnitPrice;
            product1.UnitsInStock = product.UnitsInStock;
            product1.CategoryId = product.CategoryId;


        }
    }
}
