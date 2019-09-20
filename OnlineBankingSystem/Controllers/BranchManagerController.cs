using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBankingSystem.Controllers
{
    public class BranchManagerController : Controller
    {
        // GET: BranchManager
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

        [HttpGet]
        public ActionResult PendingRequest() {

            return View();
        }

        [HttpPut]
        public ActionResult UpdateRequest() {

            return View();
        }

        [HttpGet]
        public ActionResult AllRequests() {

            return View();
        }



    }
}