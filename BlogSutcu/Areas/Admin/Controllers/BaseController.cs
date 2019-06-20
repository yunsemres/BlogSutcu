using BlogSutcu.BLL.Service;
using BlogSutcu.DAL.ORM.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSutcu.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public ProjectContext db;

        protected EntityService service;

        public BaseController()
        {
            service = new EntityService();
            db = new ProjectContext();
        }
    }
}