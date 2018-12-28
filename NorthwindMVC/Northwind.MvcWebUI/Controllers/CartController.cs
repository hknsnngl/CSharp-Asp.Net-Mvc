using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
           IProductService _productService;
        public CartController (IProductService productService)
        {
            _productService = productService;
        }
        // GET: Cart
        public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);
            //var cart =(Cart)Session["cart"];
            //if (cart == null)
            //{
            //    cart = new Cart();
            //    Session["cart"] = cart;
            //}
            cart.AddToCart(product, 1);

            return RedirectToAction("Index",cart);
        }
        public ViewResult Index(Cart cart)
        {
            //var cart = (Cart)Session["cart"];
            return View(cart);
        }
        public RedirectToRouteResult RemoveFromCart(Cart cart,int productId)
        {
            Product product = _productService.Get(productId);
            //var cart = (Cart)Session["cart"];
            //if (cart.Lines.Count==0)
            //{
            //    ModelState.AddModelError("","Urun yok");
            //}
            //else
            //{

            //}
            cart.RemoveFromCart(product);

            return RedirectToAction("Index",cart);

        }
        [HttpGet]
        public ActionResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                //managerdan veri tabanına kayıt burdan.
                return View ("Completed");
            }
            else
            {
                return View(shippingDetails);
            }

           
        }
        public  PartialViewResult CartSummary(Cart cart)
        {
        //    var cart = (Cart)Session["cart"];
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //    }
            return PartialView(cart);
        }
    }
}