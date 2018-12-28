using Northwind.Entities;

namespace Northwind.Dal.Abstract
{
    public interface IAuthenticationDal
    {
        User Authenticate(User user);
    }
}