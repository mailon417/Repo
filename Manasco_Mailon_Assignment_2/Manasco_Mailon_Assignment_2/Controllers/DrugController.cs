using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Manasco_Mailon_Assignment_2.ViewModels;

namespace Manasco_Mailon_Assignment_2.Controllers
{
    public class DrugController : Controller
    {
        //
        // GET: /Drug/


      

        public ActionResult Checkout(CheckoutVM myCheckoutVM)
        {
            myCheckoutVM.Math();

            return View(myCheckoutVM);
        }

        public ActionResult Order()
        {
            ViewBag.Message = "ACE Order Page";

            return View();
        }

    }
}
