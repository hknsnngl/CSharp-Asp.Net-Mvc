using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFreamwork;
using Northwind.Intefaces;
//14
namespace Northwind.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private IKernel _ninjectKernel;
        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            // AddBllBindings();//bll
            AddServiceBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new EfProductDal());

            _ninjectKernel.Bind<ICategoryService>().To<CategoryManager>().WithConstructorArgument("categoryDal", new EfCategoryDal());

            _ninjectKernel.Bind<IAuthenticationService>().To<AuthenticationManager>()
                .WithConstructorArgument("authenticationDal", new EfAuthenticationDal());

            
        }
        
        public void AddServiceBindings()
        {
            _ninjectKernel.Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
            _ninjectKernel.Bind<ICategoryService>().ToConstant(WcfProxy<ICategoryService>.CreateChannel());
            _ninjectKernel.Bind<IAuthenticationService>().ToConstant(WcfProxy<IAuthenticationService>.CreateChannel());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)
                _ninjectKernel.Get(controllerType);
        }
    }
}