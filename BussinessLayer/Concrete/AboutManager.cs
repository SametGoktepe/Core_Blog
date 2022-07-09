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
    public class AboutManager : IAboutService
    {
        IAboutDAL _about;

        public AboutManager(IAboutDAL about)
        {
            _about = about;
        }

        public void Add(About t)
        {
            throw new NotImplementedException();
        }

        public void Delete(About t)
        {
            throw new NotImplementedException();
        }

        public About BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
           return _about.GetListAll();
        }

        public void Update(About t)
        {
            throw new NotImplementedException();
        }
    }
}
