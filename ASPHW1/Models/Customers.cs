using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPHW1.Models
{
    public class Customers
    {
        [DisplayName("訂單編號")]
        public int CustomerID { get; set; }
        [DisplayName("出貨公司")]
        public String CompanyName { get; set; }
        [DisplayName("負責員工")]
        public String ContactName { get; set; }
        [DisplayName("出貨地址")]
        public String Address { get; set; }

        public List<Customers> GetOrderCondition()
        {
            var CustomersList = new List<Customers>()
            {
                new Customers
                {
                    CustomerID = 23,
                    CompanyName = "星船股份有限公司",
                    ContactName = "劉安閔",
                    Address = "台北市信義區五道路二段17-8號"
                },
                new Customers{
                    CustomerID = 41,
                    CompanyName = "秘密股份有限公司",
                    ContactName = "黃玉承",
                    Address = "台東縣華義路七段213-9號"
                }                
            };
            return CustomersList;
        }
    }
}