﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.DAL.ORM.Entity
{
    public class Article : BaseEntity
    {
        public string Header { get; set; }
        public string Content { get; set; }
        public DateTime? PublishDate { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
