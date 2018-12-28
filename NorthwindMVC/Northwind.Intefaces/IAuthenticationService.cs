using Northwind.Entities;
using System.ServiceModel;

namespace Northwind.Intefaces
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        User Authenticate(User user);
    }
}