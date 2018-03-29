using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPHW1.Models
{
    public class Employees
    {
        [DisplayName("客戶編號")]
        public int EmployeeID { get; set; }
        [DisplayName("名")]
        public String LastName { get; set; }
        [DisplayName("姓")]
        public String FirstName { get; set; }

        public List<Employees> GetOrderCondition()
        {
            var EmployeesList = new List<Employees>()
            {
                new Employees
                {
                    EmployeeID = 54,
                    LastName = "小美",
                    FirstName = "劉"
                },
                new Employees{
                    EmployeeID = 74,
                    LastName = "阿星",
                    FirstName = "張"
                }
            };
            return EmployeesList;
        }
    }
}