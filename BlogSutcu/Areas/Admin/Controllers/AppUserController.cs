using BlogSutcu.Areas.Admin.Models;
using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSutcu.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        public ActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUser(AppUser data)
        {
            service.AppUserService.AddUser(data);
            return Redirect("/Admin/AppUser/AppUserList");
        }
        
    }
}