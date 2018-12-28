using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFreamwork
{
    public class EfCategoryDal : ICategoryDal
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
