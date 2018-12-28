using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Intefaces
{
    [ServiceContract]
    public interface ICategoryService
    {
        [OperationContract]
        List<Category> GetAll();
    }
}
