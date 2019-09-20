using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineBankingSystem.Controllers
{
    public class AdministratorController : Controller
    {
        // GET: Administrator
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

        [HttpPut]
        public ActionResult AddBranchManager() {

            return View();
        }

        [HttpDelete]
        public ActionResult DeleteBranchManager() {

            return View();
        }

        [HttpPut]
        public ActionResult EditBranchManager(int id) {

            return View();
        }

        [HttpGet]
        public ActionResult SearchBranchManager(int id) {

            return View();
        }



    }
}