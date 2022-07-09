using BussinessLayer.Abstarct;
using DataAccessLayer.Abstarct;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;
        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category t)
        {
            _categoryDAL.Insert(t);
        }

        public void Delete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public Category BGetById(int id)
        {
            return _categoryDAL.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryDAL.GetListAll();
        }

        public void Update(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
