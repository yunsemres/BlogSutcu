﻿using BlogSutcu.BLL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSutcu.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _appUserService = new AppUserRepository();
            _articleService = new ArticleRepository();
            _categoryService = new CategoryRepository();
        }

        private AppUserRepository _appUserService;
        public AppUserRepository AppUserService
        {
            get { return _appUserService; }
            set { _appUserService = value; }
        }

        private ArticleRepository _articleService;
        public ArticleRepository ArticleService
        {
            get { return _articleService; }
            set { _articleService = value; }
        }

        private CategoryRepository _categoryService;
        public CategoryRepository CategoryService
        {
            get { return _categoryService; }
            set { _categoryService = value; }
        }
    }
}
