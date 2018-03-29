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
        [DisplayName("訂購日期")]
        public DateTime OrderDate { get; set; }
        [DisplayName("需要日期")]
        public DateTime RequiredDate { get; set; }
        [DisplayName("出貨日期")]
        public DateTime ShippedDate { get; set; }
        public int ShipperID { get; set; }
        [DisplayName("運費")]
        public Decimal Freight { get; set; }
        [DisplayName("出貨地址")]
        public String ShipAddress { get; set; }
        [DisplayName("出貨城市")]
        public String ShipCity { get; set; }
        [DisplayName("出貨地區")]
        public String ShipRegion { get; set; }
        [DisplayName("郵遞區號")]
        public String ShipPostalCode { get; set; }
        [DisplayName("出貨國家")]
        public String ShipCountry { get; set; }

        public List<Orders> GetOrderCondition()
        {
            var OrdersList = new List<Orders>()
            {
                new Orders
                {
                    OrderID = 1,
                    CustomerID = 1,
                    EmployeeID = 2,
                    OrderDate = Convert.ToDateTime("2018-04-21"),
                    RequiredDate = Convert.ToDateTime("2018-05-21"),
                    ShippedDate = Convert.ToDateTime("2018-05-04"),
                    ShipperID = 3,
                    Freight = 500,
                    ShipAddress = "豆豆龍路11-4號",
                    ShipCity = "台中市",
                    ShipRegion = "清水區",
                    ShipPostalCode = "406",
                    ShipCountry = "臺灣"
                },
                new Orders{
                    OrderID = 3,
                    CustomerID = 5,
                    EmployeeID = 7,
                    OrderDate = Convert.ToDateTime("2017-01-26"),
                    RequiredDate = Convert.ToDateTime("2017-02-23"),
                    ShippedDate = Convert.ToDateTime("2017-02-06"),
                    ShipperID = 6,
                    Freight = 60,
                    ShipAddress = "麵包路121段17巷37號2樓",
                    ShipCity = "台北市",
                    ShipRegion = "信義區",
                    ShipPostalCode = "506",
                    ShipCountry = "臺灣"
                }


            };
            return OrdersList;
        }
    }

    

}