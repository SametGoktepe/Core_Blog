using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using Core_Blog.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Controllers
{
    public class WriterController : Controller
    {
        AuthorManager arm = new AuthorManager(new EFAuthorRepository());
        UserManager userM = new UserManager(new EFUserRepository());
        AuthorValidator av = new AuthorValidator();
        Context c = new Context();
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var user = User.Identity.Name;
            ViewBag.v = user;
            Context c = new Context();
            var authorName = c.Authors.Where(x => x.AuthorMail == user).Select(z => z.AuthorName).FirstOrDefault();
            ViewBag.v2 = authorName;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterUpNavbarPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> AuthorEditProfile()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.name_surname = values.Name_Surname;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AuthorEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.Name_Surname = model.name_surname;
            values.UserName = model.username;
            values.ImageUrl = model.imageurl;
            values.Email = model.mail;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values,model.password);
            var result = await _userManager.UpdateAsync(values);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }   
            return View();
        }

        [HttpGet]
        public IActionResult AuthorAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AuthorAdd(AddProfileImage p)
        {
            Author a = new Author();
            if (p.AuthorImage != null)
            {
                var extension = Path.GetExtension(p.AuthorImage.FileName);
                var newiamgename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AuthorImageFile/", newiamgename);
                var stream = new FileStream(location, FileMode.Create);
                p.AuthorImage.CopyTo(stream);
                a.AuthorImage = newiamgename;
            }
            a.AuthorName = p.AuthorName;
            a.AuthorMail = p.AuthorMail;
            a.AuthorPassword = p.AuthorPassword;
            a.Status = true;
            a.AuthorAbout = p.AuthorAbout;
            arm.Add(a);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
