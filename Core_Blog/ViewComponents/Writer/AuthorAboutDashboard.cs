using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.ViewComponents.Writer
{
    public class AuthorAboutDashboard:ViewComponent
    {
        AuthorManager arm = new AuthorManager(new EFAuthorRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var username = User.Identity.Name;
            ViewBag.vv = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var authorID = c.Authors.Where(x => x.AuthorMail == usermail).Select(z => z.AuthorID).FirstOrDefault();
            var values = arm.GetAuthorByID(authorID);
            return View(values);
        }
    }
}
