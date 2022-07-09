﻿using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.ViewComponents.Blog
{
    public class BlogListDashboard : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
    }
}
