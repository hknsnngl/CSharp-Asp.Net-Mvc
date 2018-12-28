using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//(6-9)
namespace Northwind.Intefaces
{
    [ServiceContract] //servis için gerekli.
     public interface IProductService
    {
        //UI hem iş katmanına hemde servise gitmeli.
        //UI ayrı ayrı gitmesi yerine ikisini kapsayan tek interface gitmeli.
        //işte bu o interface
        [OperationContract]//Servis için gerekli
        List<Product> GetAll();
        [OperationContract]
        Product Get(int productId);
        [OperationContract]
        void Add(Product product);
        [OperationContract]
        void Delete(int productId);
        [OperationContract]
        void Update(Product product);

    }
}
