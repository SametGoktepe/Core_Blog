using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Enter User Name")]
        public string username { get; set; }
        [Required(ErrorMessage = "Enter User Name")]
        public string password { get; set; }
    }
}
