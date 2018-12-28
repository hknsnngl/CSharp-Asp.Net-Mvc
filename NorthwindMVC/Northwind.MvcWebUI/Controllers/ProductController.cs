using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFreamwork;
using Northwind.Entities;
using Northwind.Intefaces;
using Northwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//11-14
namespace Northwind.MvcWebUI.Controllers
{
   
    public class ProductController : Controller
    {

       
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public int pageSize = 5;
        public ViewResult Index(int page = 1,int category=0)
        {
            List<Product> products = _productService.GetAll()
                .Where(p=>p.CategoryID==category||category==0).ToList();// /?Category=2

            return View(new ProductViewModel {
                Products = products.Skip((page - 1) * pageSize).Take(5).ToList(),
                PagingInfo = new PagingInfo {
                    ItemsPerPage = pageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory=category
                }
        });
           
            
        }
                                    
    }
}
          
    

//Controllers+add+Controller+MVC5 Empty
//istekleri ilk karşılayan Controler.
//Index Aksiyonu
//set as startup proje ordan baslar demek.

//Viev a gider Product arar sonra Index i.
/*  ürünlerin listelenmesi için view ın
    Bll yada Service baglanması gerekir.    
*/
// ProductManager _productManager = new ProductManager(new EfProductDal()); 
//yukardakinin yerine
//_productManager