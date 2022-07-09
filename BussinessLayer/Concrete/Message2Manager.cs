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
    public class Message2Manager : IMessage2Service
    {
        IMessage2DAL _message2DAL;

        public Message2Manager(IMessage2DAL message2DAL)
        {
            _message2DAL = message2DAL;
        }

        public void Add(Message2 t)
        {
            _message2DAL.Insert(t);
        }

        public Message2 BGetById(int id)
        {
            return _message2DAL.GetById(id);
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetList()
        {
           return _message2DAL.GetListAll();
        }

        public List<Message2> GetListInboxByAuthor(int p)
        {
            return _message2DAL.GetInboxWithMessageByAuthor(p);
        }

        public List<Message2> GetListSenboxByAuthor(int p)
        {
            return _message2DAL.GetSendBoxWithMessageByAuthor(p);
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
