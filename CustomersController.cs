using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Controllers
{
    public class CustomersController : Controller
    {
        NorthwindEntities ne = new NorthwindEntities();
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCust_Residing_in_Germany()
        {
            List<string> cname = (from cust in ne.Customers
                                  where cust.Country == "Germany"
                                  select cust.ContactName).ToList();
            return View(cname);
        }
        public ActionResult GetCustDetails()
        {
            List<Customer> cus = (from cust in ne.Customers
                                   join o in ne.Orders
                                   on cust.CustomerID equals o.CustomerID
                                   where o.OrderID == 10248
                                   select cust).ToList();
            return View(cus);
        }
    }
}