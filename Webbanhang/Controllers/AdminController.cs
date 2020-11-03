using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webbanhang.Models;
using System.Data;
namespace Webbanhang.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DatHangModel dbdh = new DatHangModel();
        public ActionResult Index()
        {
            List<DatHang> dsdh = dbdh.getalldonhang(); ;

            return View(dsdh);
        }
    }
}