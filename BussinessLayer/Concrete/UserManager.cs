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
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Add(AppUser t)
        {
            _userDAL.Insert(t);
        }

        public AppUser BGetById(int id)
        {
            return _userDAL.GetById(id);
        }

        public void Delete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(AppUser t)
        {
            _userDAL.Update(t);
        }
    }
}
