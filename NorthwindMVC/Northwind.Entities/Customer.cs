using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{   //ENTİTİES
    //VT TABLO OBJE OLUŞTURULUR.
    public class Customer  //Public olmalı.
    {
        //prop
        //Tablo attributeların get set metodlarını yazmalıyız.
        public string CustomerID { get; set; } //Tablo attribute ismi ile aynı CustomerID.
        /*
            private string _customerID;
            public string CustomerID{
                get{return _customerID;}
                set{_customerID=value;}
            }     
        */
        public string ContactName { get; set; }
        public  string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
