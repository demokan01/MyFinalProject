using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<product> _products;//global
        public InMemoryProductDal()
        {
            //Oracle,SQL Server,Postgres,MongoDb
            _products = new List<product> { 
                new product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new product{ProductId=5,CategoryId=2,ProductName="Mouse",UnitPrice=85,UnitsInStock=1}
            };       
        }
        public void Add(product product)
        {
            _products.Add(product);
        }

        public void Delete(product product)
        {
            //LINQ - Language Integrated Query
            
            //Product productToDelete = null;
            
            //LINQ ile çalışmıyor olsaydık
            
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            
            //Lambda 
            product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);//yukarıdaki foreachin yaptığı işi yapar


            _products.Remove(productToDelete);
        }

        public List<product> GetAll()
        {
            return _products;
        }

        public List<product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
