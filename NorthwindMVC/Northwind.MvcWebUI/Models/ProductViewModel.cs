using System.Collections.Generic;
using Northwind.Entities;

namespace Northwind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; internal set; }
    }
}