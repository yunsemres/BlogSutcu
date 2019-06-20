using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.DAL.ORM.Map
{
    public class CategoryMap : BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Category");
            Property(x => x.CategoryName).IsOptional();
            Property(x => x.CategoryDescription).IsOptional();
        }
    }
}
