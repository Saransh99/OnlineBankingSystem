using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBankingSystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login() {

            return View();
        }
        public ActionResult Logout() {

            return View();
        }
        public ActionResult RequestStatus() {

            return View();
        }
        public ActionResult Register() {

            return View();
        }
        public ActionResult AccountDetails() {

            return View();
        }
        public ActionResult AccountStatement() {

            return View();
        }
        public ActionResult AddBeneficiary() {

            return View();
        }
        public ActionResult TransferFunds() {

            return View();
        }
    }
}