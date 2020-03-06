using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoBancario.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuario()
        {
            return View();
        }

        public ActionResult Transferencia()
        {
            return View();
        }

        public ActionResult Saque()
        {
            return View();
        }

        public ActionResult Deposito()
        {
            return View();
        }

        public ActionResult Extrato()
        {
            return View();
        }

        public ActionResult Extorno()
        {
            return View();
        }
    }
}