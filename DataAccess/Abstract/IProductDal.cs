﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails(); // Ürün detaylarını listeleme metodu
    }
}

// Code Refactoring

//List<Product> GetAll();
//void Add(Product product);
//void Delete(Product product);
//void Update(Product product);
//List<Product> GetAllByCategory(int categoryId); //Kategoriye göre ürünleri listeleme metodu
