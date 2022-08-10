using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClientWebApp2.Controllers
{
    public class ClientBooksController : Controller
    {
        // GET: ClientBooks
        public ActionResult Index()
        {
            return View();
        }
    }
}