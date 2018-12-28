using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFreamwork;
using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.WcfLibrary.Concrete
{
    class CategoryService : ICategoryService
    {
        CategoryManager _categorManager = new CategoryManager(new EfCategoryDal());
        public List<Category> GetAll()
        {
            return _categorManager.GetAll();
        }
    }
}
