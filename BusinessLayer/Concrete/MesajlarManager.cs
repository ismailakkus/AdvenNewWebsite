using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MesajlarManager : IMesajlarService
    {
        IMesajlarDAL _mesajlarDAL;

        public MesajlarManager(IMesajlarDAL mesajlarDAL)
        {
            _mesajlarDAL = mesajlarDAL;
        }

        public void TAdd(Mesajlar t)
        {
            _mesajlarDAL.Insert(t);
        }

        public void TDelete(Mesajlar t)
        {
            _mesajlarDAL.Delete(t);
        }

        public Mesajlar TGetByID(int id)
        {
            return _mesajlarDAL.GetByID(id);
        }

        public List<Mesajlar> TGetList()
        {
            return _mesajlarDAL.GetList();
        }

        public void TUpdate(Mesajlar t)
        {
            _mesajlarDAL.Update(t);
        }
    }
}
