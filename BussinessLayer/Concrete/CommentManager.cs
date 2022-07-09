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
    public class CommentManager : ICommentService
    {
        ICommentDAL _commnetdal;

        public CommentManager(ICommentDAL commnetdal)
        {
            _commnetdal = commnetdal;
        }

        public void Add(Comment t)
        {
            _commnetdal.Insert(t);
        }

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _commnetdal.GetListAll(x => x.BlogID == id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetBlogListWithComment()
        {
            return _commnetdal.GetListWithBlog();
        }
    }
}
