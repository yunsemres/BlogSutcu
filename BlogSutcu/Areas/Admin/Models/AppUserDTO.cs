﻿using BlogSutcu.DAL.ORM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSutcu.Areas.Admin.Models
{
    public class AppUserDTO : BaseDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public Gender Gender { get; set; }
    }
}