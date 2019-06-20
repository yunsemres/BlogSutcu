using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.DAL.ORM.Map
{
    public class AppUserMap : BaseMap <AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.AppUser");
            Property(x => x.FirstName).IsOptional();
            Property(x => x.LastName).IsOptional();
            Property(x => x.UserName).HasMaxLength(50).IsRequired();
            Property(x => x.Password).HasMaxLength(50).IsRequired();
            Property(x => x.Email).IsOptional();
            Property(x => x.Role).IsOptional();
            Property(x => x.Gender ).IsOptional();

            HasMany(x => x.Articles)
                .WithRequired(x => x.AppUser)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
        }
    }
}
