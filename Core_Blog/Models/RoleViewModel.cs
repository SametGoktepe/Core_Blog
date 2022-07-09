using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage ="Enter Role Name")]
        public string Name { get; set; }
    }
}
