using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();
        public IActionResult Inbox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Authors.Where(x => x.AuthorMail == usermail).Select(x => x.AuthorID).FirstOrDefault();
            var values = mm.GetListInboxByAuthor(writerID);
            return View(values);
        }

        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Authors.Where(x => x.AuthorMail == usermail).Select(x => x.AuthorID).FirstOrDefault();
            var values = mm.GetListSenboxByAuthor(writerID);
            return View(values);
        }
        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ComposeMessage(Message2 m)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Authors.Where(x => x.AuthorMail == usermail).Select(x => x.AuthorID).FirstOrDefault();
            m.SenderID = writerID;
            m.ReciverID = 1;
            m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.Add(m);
            return RedirectToAction("SendBox");
        }
    }
}
