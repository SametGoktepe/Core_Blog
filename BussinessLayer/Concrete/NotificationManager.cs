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
    public class NotificationManager : INotificationService
    {
        INotificationDAL _notifDal;

        public NotificationManager(INotificationDAL notifDal)
        {
            _notifDal = notifDal;
        }

        public void Add(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification BGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Notification t)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notifDal.GetListAll();
        }

        public void Update(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
