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
    public class AuthorManager : IAuthorService
    {
        IAuthorDAL _author;

        public AuthorManager(IAuthorDAL author)
        {
            _author = author;
        }

        public void Add(Author t)
        {
            _author.Insert(t);
        }

        public void Delete(Author t)
        {
            throw new NotImplementedException();
        }

        public Author BGetById(int id)
        {
            return _author.GetById(id);
        }

        public List<Author> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Author t)
        {
             _author.Update(t);
        }

        public List<Author> GetAuthorByID(int id)
        {
            return _author.GetListAll(x => x.AuthorID == id);   
        }
    }
}
