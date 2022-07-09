using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Blog.Models
{
    public class UserUpdateViewModel
    {
        public string name_surname { get; set; }
        public string username { get; set; }
        public string mail { get; set; }
        public string imageurl { get; set; }
        public string password { get; set; }
    }
}
