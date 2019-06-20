using BlogSutcu.Areas.Admin.Models.VM;
using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogSutcu.Areas.Admin.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Login()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin/Login/UserLogin");
            }
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(LoginVM credential)
        {
            if (ModelState.IsValid)
            {
                if (service.AppUserService.CheckCredentials(credential.Email, credential.Password))
                {
                    AppUser user = service.AppUserService.FindByUserName(credential.Email);

                    string cookie = user.UserName;
                    FormsAuthentication.SetAuthCookie(cookie, true);
                    //return Redirect("/Admin/Home/Index");
                    if (user.Role == BlogSutcu.DAL.ORM.Enum.Role.Admin)
                    {
                        return Redirect("/Admin/Home/Index");
                    }
                    else if (user.Role == DAL.ORM.Enum.Role.Member)
                    {
                        return Redirect("/Admin/Home/Member");
                    }
                    else
                    {
                        return View();
                    }

                }
                else
                {
                    ViewData["error"] = "Kullanıcı adı veya şifre Hatalı";
                    return View();
                }
            }

            return View();
        }
    }
}