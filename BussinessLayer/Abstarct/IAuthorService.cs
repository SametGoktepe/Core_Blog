using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstarct
{
    public interface IAuthorService:IGenericService<Author>
    {
        List<Author> GetAuthorByID(int id);
    }
}
