using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StructureMapMVC5.Models;

namespace StructureMapMVC5.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageFactory _messageFactory;

        public HomeController(IMessageFactory messageFactory)
        {
            _messageFactory = messageFactory;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _messageFactory.GetMessage();
            return View();
        }

    }
}