using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBankingSystem.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreditCardEMI() {

            return View();
        }
        public ActionResult HomeLoanEMI() {

            return View();
        }
        public ActionResult FourWheelerEMI() {

            return View();
        }
        public ActionResult TwoWheelerEMI() {

            return View();
        }
    }
}