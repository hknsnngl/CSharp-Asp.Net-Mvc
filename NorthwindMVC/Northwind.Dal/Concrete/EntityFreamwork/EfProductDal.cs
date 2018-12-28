using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(3-)
namespace Northwind.Dal.Concrete.EntityFreamwork
{
    //IProductDal kalıtım yoluyla referans aldık ve implement ettik.
    public class EfProductDal : IProductDal
    {
        private NorthwindContext _contenxt = new NorthwindContext();
        public void Add(Product product)
        {   //ekleme
            _contenxt.Products.Add(product);
            _contenxt.SaveChanges();
        }

        public void Delete(int productId)
        {   //silme
            _contenxt.Products.Remove(_contenxt.Products.FirstOrDefault(p => p.ProductID == productId));
            _contenxt.SaveChanges();
        }

        public Product Get(int productId)
        {
            //Tek ürün getir
            return _contenxt.Products.FirstOrDefault(p => p.ProductID == productId);
        }

        public List<Product> GetAll()
        {
            //tüm ürünleri Liste olarak getir.
            return _contenxt.Products.ToList();
        }

        public void Update(Product product)
        {
            //güncelleme
            Product productUpdate = _contenxt.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryID = product.CategoryID;
            productUpdate.UnitPrice = product.UnitPrice;
            //productUpdate.UnitsInStock = product.UnitsInStock;
            _contenxt.SaveChanges();

        }
    }
}
