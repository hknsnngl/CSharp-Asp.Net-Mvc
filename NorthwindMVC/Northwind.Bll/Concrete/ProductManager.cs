using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(7)
namespace Northwind.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        //İş katmanı kimden kalıtım alıcak olusturdugum hemn iş hemde servis için olan interfaceden alır.
        //verileri data katmanından(dal) ister yani dal abstract dan alır.
        //böyle olmalı//
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        //***********//
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(int productId)
        {
            _productDal.Delete(productId);
        }

        public Product Get(int productId)
        {           
            return _productDal.Get(productId);
        }

        // EfProductDal  productDal = new EfProductDal();
        public List<Product> GetAll()
        {
            //validation,ex.handling,security...
            //return productDal.GetAll();
            /*Comment olanı yaparsam;
             * Bir gün EF uzaklaşmak istediğimden bu katmandaki herşey değişir
             * dolayısıyla bu katmanın ust katmana bagımlı olmaması için 
             *boyle olmalı.
             
             */
            return _productDal.GetAll();
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
