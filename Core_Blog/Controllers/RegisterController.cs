using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager wm = new AuthorManager(new EFAuthorRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Author a)
        {
            AuthorValidator ar = new AuthorValidator();
            ValidationResult results = ar.Validate(a);
            if (results.IsValid)
            {
                a.Status = true;
                a.AuthorAbout = "User";
                wm.Add(a);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
    }
}
