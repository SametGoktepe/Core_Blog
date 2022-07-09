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
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDAL _newsletter;

        public NewsLetterManager(INewsLetterDAL newsletter)
        {
            _newsletter = newsletter;
        }

        public void Add(NewsLetter t)
        {
            _newsletter.Insert(t);
        }
        public void Delete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public NewsLetter BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
