using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c=new Context())
            {
                return c.Blogs.Include(a => a.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByAuthor(int id)
        {
            using (var c = new Context())
            {
                return c.Blogs.Include(a => a.Category).Where(x=>x.AuthorID==id).ToList();
            }
        }
    }
}
