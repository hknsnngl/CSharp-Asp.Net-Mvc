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
    public class AuthenticationService : IAuthenticationService
    {
        AuthenticationManager _authenticationManager = new AuthenticationManager(new EfAuthenticationDal());
        public User Authenticate(User user)
        {
            return _authenticationManager.Authenticate(user);
        }
    }
}
