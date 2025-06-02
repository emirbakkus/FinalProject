using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;   //Global değişken olarak tanımlandı. Bu sayede tüm metotlarda erişilebilir.O yüzden _ ile başlar.
        public InMemoryProductDal() //constructor metodu
        {
            // Oracle ,Sql Server ,PostgreSQL , MongoDb gibi veritabanı sistemlerinde bu işlemler yapılır.
            _products = new List<Product> { 
              new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitsInStock=15, UnitPrice=15},
              new Product{ProductId=2, CategoryId=2, ProductName="Kamera", UnitsInStock=3, UnitPrice=500},
              new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitsInStock=2, UnitPrice=1500},
              new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitsInStock = 65, UnitPrice =150},
              new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitsInStock = 1, UnitPrice =85},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query(Dile Gömülü Sorgulama) 
            //LINQ kullanarak silme işlemi
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);

            // ***LINQ kullanmadan manuel olarak silme işlemi***
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}
            // _products.Remove(productToDelete); 
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList(); //LINQ kullanarak kategoriye göre ürünleri listeleme
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName; //Ürünün adını güncelle
            productToUpdate.CategoryId = product.CategoryId; //Ürünün kategorisini güncelle
            productToUpdate.UnitPrice = product.UnitPrice; //Ürünün fiyatını güncelle
            productToUpdate.UnitsInStock = product.UnitsInStock; //Ürünün stok miktarını güncelle
        }
    }
}
