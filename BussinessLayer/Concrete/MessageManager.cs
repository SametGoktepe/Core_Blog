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
    public class MessageManager : IMessageService
    {
        IMessageDAL _messageDAL;

        public MessageManager(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void Add(Message t)
        {
            throw new NotImplementedException();
        }

        public Message BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message t)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetList()
        {
            return _messageDAL.GetListAll();
        }

        public List<Message> GetListInboxByAuthor(string p)
        {
            return _messageDAL.GetListAll(x => x.Reciver == p);
        }

        public void Update(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
