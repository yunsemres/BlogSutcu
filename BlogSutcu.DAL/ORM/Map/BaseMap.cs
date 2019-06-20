﻿using BlogSutcu.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.DAL.ORM.Map
{
    public class BaseMap <T> : EntityTypeConfiguration <T> where T : BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.ID).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.AddDate).HasColumnName("AddDate").IsOptional();
            Property(x => x.UpdateDate).HasColumnName("UpdateDate").IsOptional();
            Property(x => x.DeleteDate).HasColumnName("DeleteDate").IsOptional();
            Property(x => x.Status).HasColumnName("Status").IsOptional();
        }
    }
}
