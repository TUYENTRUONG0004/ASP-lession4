using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TDTlesion4.Controllers
{
    public class TDTCustomerScaffDingController : Controller
    {
        private static List<TDTCustomer> listCustomer = new List<TDTCustomer>()
            {
                new TDTCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Truong Dinh",
                     LastName = "Tuyen",
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
                     FirstName = "Lê Trần Khánh",
                     LastName = "Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TDTCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
        // GET: TDTCustomerScaffDing
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult TDTCreate()
        {
            var model = new TDTCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult TDTCreate(TDTCustomer model)
        {
            listCustomer.Add(model);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult TDTEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x => x.CustomerID == id);
            return View(customer);
        }
    }
}