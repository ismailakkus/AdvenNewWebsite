using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KullanicilarManager : IKullanicilarService
    {
        IKullanicilarDAL _kullanicilarDAL;
        public KullanicilarManager(IKullanicilarDAL kullanicilarDAL)
        {
            _kullanicilarDAL = kullanicilarDAL;
        }

        public void TAdd(Kullanicilar t)
        {
            _kullanicilarDAL.Insert(t);
        }

        public void TDelete(Kullanicilar t)
        {
            _kullanicilarDAL.Delete(t);
        }

        public Kullanicilar TGetByID(int id)
        {
            return _kullanicilarDAL.GetByID(id);
        }

        public List<Kullanicilar> TGetList()
        {
            return _kullanicilarDAL.GetList();
        }

        public void TUpdate(Kullanicilar t)
        {
            _kullanicilarDAL.Update(t);
        }
    }
}
