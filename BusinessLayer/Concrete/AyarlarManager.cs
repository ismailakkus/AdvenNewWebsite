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
    public class AyarlarManager : IAyarlarService
    {
        IAyarlarDAL _ayarlarDAL;

        public AyarlarManager(IAyarlarDAL ayarlarDAL)
        {
            _ayarlarDAL = ayarlarDAL;
        }

        public void TAdd(Ayarlar t)
        {
            _ayarlarDAL.Insert(t);
        }

        public void TDelete(Ayarlar t)
        {
            _ayarlarDAL.Delete(t);
        }

        public Ayarlar TGetByID(int id)
        {
            return _ayarlarDAL.GetByID(id); 
        }

        public List<Ayarlar> TGetList()
        {
            return _ayarlarDAL.GetList();
        }

        public void TUpdate(Ayarlar t)
        {
            _ayarlarDAL.Update(t);
        }
    }
}
