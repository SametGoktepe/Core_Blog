using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Controllers
{
    public class MessageController : Controller
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

        public IActionResult MessageDetails(int id)
        {
            var values = mm.BGetById(id);
            return View(values);
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message2 m)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Authors.Where(x => x.AuthorMail == usermail).Select(x => x.AuthorID).FirstOrDefault();
            m.SenderID = writerID;
            m.ReciverID = 1;
            m.Status = true;
            m.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            mm.Add(m);
            return RedirectToAction("Inbox");
        }
    }
}
