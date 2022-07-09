using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFMessage2Repository : GenericRepository<Message2>, IMessage2DAL
    {
        public List<Message2> GetInboxWithMessageByAuthor(int id)
        {
            using (var c = new Context())
            {
                return c.Messages2.Include(x => x.SenderUser).Where(x => x.ReciverID == id).ToList();
            }
        }

        public List<Message2> GetSendBoxWithMessageByAuthor(int id)
        {
            using (var c=new Context())
            {
                return c.Messages2.Include(x => x.ReciverUser).Where(x => x.SenderID == id).ToList();
            }
        }
    }
}
