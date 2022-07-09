using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Name Surname")]
        [Required(ErrorMessage = "Enter Name Surname")]
        public string Name_Surname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password Not Match")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Enter Mail")]
        public string Mail { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "Enter User Name")]
        public string UserName { get; set; }

        //[Required(ErrorMessage ="Accpet the Terms")]
        //public bool IsAcceptTheContract { get; set; }
    }
}
