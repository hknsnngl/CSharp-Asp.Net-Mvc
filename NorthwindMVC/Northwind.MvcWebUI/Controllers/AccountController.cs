using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _authenticationService;
        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        // GET: Account
        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Login(User user,string returnUrl)
        {
            User validateUSer = _authenticationService.Authenticate(user);

            if (validateUSer == null)
            {
                ModelState.AddModelError("Hata", "Kullanıcı adı veya sifre hatali");
            }
            if (ModelState.IsValid)
            {                                   
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return Redirect(returnUrl);            
            }
         
            return View();
        }
    }
}