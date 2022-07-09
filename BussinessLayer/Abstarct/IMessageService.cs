using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstarct
{
    public interface IMessageService : IGenericService<Message>
    {
        List<Message> GetListInboxByAuthor(string p);
    }
}
