using AsmNewTest.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsmNewTest.Controllers
{
    public class ManageRoleController : Controller
    {
        asmEntities context = new asmEntities();

        // GET: ManageRole
        public ActionResult Index()
        {
            var Model = context.Roles.ToList();
            return View(Model);
        }

    }
}