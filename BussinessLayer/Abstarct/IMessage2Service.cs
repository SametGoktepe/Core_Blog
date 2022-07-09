using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstarct
{
    public interface IMessage2Service: IGenericService<Message2>
    {
        List<Message2> GetListInboxByAuthor(int p);
        List<Message2> GetListSenboxByAuthor(int p);

    }
}
