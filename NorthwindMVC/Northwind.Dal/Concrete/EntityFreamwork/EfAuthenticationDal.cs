using Northwind.Dal.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Dal.Concrete.EntityFreamwork
{
    public class EfAuthenticationDal : IAuthenticationDal
    {
        public User Authenticate(User user)
        {
            //veri tabandan alıncak
            if (user.UserName == "hakan" && user.Password == "123")
            {
                return user;
            }
            return null;
        }
    }
}
