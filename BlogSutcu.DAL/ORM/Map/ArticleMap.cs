using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.DAL.ORM.Map
{
    public class ArticleMap : BaseMap <Article>
    {
        public ArticleMap()
        {
            ToTable("dbo.Article");
            Property(x => x.Header).IsOptional();
            Property(x => x.Content).IsOptional();
            Property(x => x.PublishDate).IsOptional();

            HasRequired(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryID)
                .WillCascadeOnDelete(false);

            HasRequired(x => x.AppUser)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.AppUserID)
                .WillCascadeOnDelete(false);
        }
    }
}
