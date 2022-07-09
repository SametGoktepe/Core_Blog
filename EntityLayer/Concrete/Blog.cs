using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime CreateDate { get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
        public string ThumbNailImage { get; set; }


        //Relations
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int AuthorID { get; set; }
        public AppUser Authors { get; set; }
    }
}
