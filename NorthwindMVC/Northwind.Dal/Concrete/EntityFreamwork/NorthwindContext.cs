using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(4)
namespace Northwind.Dal.Concrete.EntityFreamwork
{
    public class NorthwindContext:DbContext
    {
        //Products(tablo)'ı vt bağlama                //Tablonun her satırının turu Product.
        public DbSet<Product> Products { get; set; } //Products tablo ile entity ilişkilendirme   
        public DbSet<Category> Categories { get; set; }
    }
}
