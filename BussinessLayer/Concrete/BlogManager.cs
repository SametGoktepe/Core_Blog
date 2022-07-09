using BussinessLayer.Abstarct;
using DataAccessLayer.Abstarct;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public List<Blog> GetBlogByID(int id)
        {
            return _blogDAL.GetListAll(x => x.BlogID == id);
        }
        public List<Blog> GetList()
        {
            return _blogDAL.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDAL.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDAL.GetListAll(x => x.AuthorID == id);
        }
        public List<Blog> GetListWithCategoryByAuthorbm(int id)
        {
            return _blogDAL.GetListWithCategoryByAuthor(id);
        }

        public void Add(Blog t)
        {
            _blogDAL.Insert(t);
        }

        public void Delete(Blog t)
        {
            _blogDAL.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogDAL.Update(t);
        }

        public Blog BGetById(int id)
        {
            return _blogDAL.GetById(id);
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

    }
}
