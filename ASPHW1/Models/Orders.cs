using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPHW1.Models
{
    public class Orders
    {
        [DisplayName("訂單編號")]
        public int OrderID { get;set;}
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }

        public int OrderDate { get; set; }
    }
}