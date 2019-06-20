using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogSutcu.Areas.Admin.Models.VM
{
    public class LoginVM
    {
        [
            EmailAddress(ErrorMessage = "Yanlış E-Mail"),
            Required(ErrorMessage = "Lütfen E-Mail Giriniz"),
            DisplayName("E-Posta")
        ]
        public string Email { get; set; }

        [
            Required(ErrorMessage = "Lütfen Şifre Giriniz"),
            DisplayName("Password")
        ]
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}