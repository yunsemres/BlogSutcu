using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.BLL.Repository
{
    public class AppUserRepository : BaseRepository <AppUser>
    {
        public bool CheckCredentials(string Email, string Password)
        {
            return tablo.Any(x => x.Email == Email && x.Password == Password);
        }

        public AppUser FindByUserName(string Email)
        {
            return tablo.FirstOrDefault(x => x.Email == Email);
        }

        public void AddUser(AppUser data)
        {
            throw new NotImplementedException();
        }
    }
}
