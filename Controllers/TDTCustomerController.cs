using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDTlesion4.Controllers
{
    public class TDTCustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Action: LHLCustomerDetails
        public ActionResult TDTCustomerDetails()
        {
            //tạo đối tượng trong dữ liệu 
            var customer = new TDTCustomer()
            {
                CustomerID = 1,
                FirstName = "Lê Hoàng",
                LastName = "Long",
                Address = "K22CNT3",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult TDTlistCustomer()
        {
            var list = new List<TDTCustomer>()
            {
                new TDTCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Lê Hoàng",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TDTCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Ngô Hoàng",
                     LastName = "Minh",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TDTCustomer()
                {
                     CustomerID = 2,
                     FirstName = truong dinh",
                     LastName = "tuyen",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TDTCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Anh",
                     LastName = "Duong",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
            ViewBag.list = list;
            return View();
        }
    }
}