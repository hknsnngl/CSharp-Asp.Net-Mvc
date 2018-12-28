using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(2)
namespace Northwind.Dal.Abstract
{
    public interface IProductDal
    {
        //DAL => Veri işleme.
        List<Product> GetAll();     //Tümünü getir
        Product Get(int productId); //Bir tane getir
        void Add(Product product);  //Ekle
        void Delete(int productId); //sil
        void Update(Product product);   //Güncelle
    }
}
