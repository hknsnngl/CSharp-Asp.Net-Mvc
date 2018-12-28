using Northwind.Dal.Abstract;
using Northwind.Entities;
using Northwind.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bll.Concrete
{
    public class AuthenticationManager : IAuthenticationService
    {
        private IAuthenticationDal _authenticationDal;
        public  AuthenticationManager(IAuthenticationDal authenticationDal)
        {
            _authenticationDal = authenticationDal;
        }
        public User Authenticate(User user)
        {
            return _authenticationDal.Authenticate(user);
        }
    }
}
