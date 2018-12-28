using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFreamwork;
using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
//(8)
namespace Northwind.WcfLibrary.Concrete
{
    public class ProductService : IProductService //inherit edilir.
    {
        //Servis uyg construct olmaz... şimdilik kullanıyoz.
        //Bunun bi alt katmanından almalı o da iş katmanı
        //instance provider ile ezilecek.
        private ProductManager _productManager = new ProductManager(new EfProductDal());
        public void Add(Product product)
        {
            _productManager.Add(product);
        }

        public void Delete(int productId)
        {
            _productManager.Delete(productId);
        }

        public Product Get(int productId)
        {
            return _productManager.Get(productId);
        }

        public List<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public void Update(Product product)
        {
            _productManager.Update(product);
        }
    }
}
