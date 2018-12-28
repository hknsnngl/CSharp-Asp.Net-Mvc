using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//(1)
namespace Northwind.Entities
{
    public class Product
    {
        //[System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        // public int UnitsInStock { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]

        public int CategoryID { get; set; } //Tablo ilişkilendirme
    }
}
